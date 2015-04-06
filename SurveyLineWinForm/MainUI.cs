using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using SurveyLine.Core;
using SurveyLineWinForm.Forms;
using SurveyLineWinForm.Util;
using ZedGraph;

namespace SurveyLineWinForm
{
    /// <summary>
    ///     Description of MainForm.
    /// </summary>
    public partial class MainUI : Form
    {
        private SurveyFactory _surveyFactory;
        private bool _alreadyFocused;
        FormWindowState _lastWindowState;
        private readonly GraphPane _myPane;
        
        public MainUI()
        {
            InitializeComponent();

            #region Zedgraph Setup
            _myPane = zgcSurveyPlot.GraphPane;
            _myPane.Chart.Border.Color = Color.Gray;
            _myPane.IsFontsScaled = false;
            _myPane.Title.IsVisible = false;
            _myPane.Border.Color = Color.White;
            

            _myPane.YAxis.MajorGrid.IsVisible = true;
            _myPane.YAxis.MajorGrid.Color = Color.Gray;
            _myPane.YAxis.Scale.FontSpec.Size = 10.0f;
            _myPane.YAxis.Scale.IsVisible = true;
            _myPane.YAxis.Title.IsVisible = false;
            _myPane.YAxis.Scale.MagAuto = true;
            _myPane.YAxis.MinorTic.IsAllTics = false;
            _myPane.YAxis.MajorTic.IsAllTics = true;
            _myPane.YAxis.MajorTic.Color = Color.Gray;

            _myPane.XAxis.MajorGrid.IsVisible = true;
            _myPane.XAxis.MajorGrid.Color = Color.Gray;
            _myPane.XAxis.Scale.FontSpec.Size = 10.0f;
            _myPane.XAxis.Scale.IsVisible = true;
            _myPane.XAxis.Scale.MagAuto = true;
            _myPane.XAxis.Title.IsVisible = false;
            _myPane.XAxis.MinorTic.IsAllTics = false;
            _myPane.XAxis.MajorTic.IsAllTics = true;
            _myPane.XAxis.MajorTic.Color = Color.Gray;

            _myPane.Legend.IsVisible = false;

            var points = new PointPairList();
            var myCurve = _myPane.AddCurve("Test Curve1", points, Color.Blue, SymbolType.None);


            points.Add(1000, 2000);
            points.Add(5000, 3000);
            
            _myPane.AxisChange();

            var chartRect = _myPane.CalcChartRect(zgcSurveyPlot.CreateGraphics());
            _myPane.Chart.Rect = GetEqualRatioRect(chartRect);


            #endregion
        }

        RectangleF GetEqualRatioRect(RectangleF rect)
        {
            if (rect.Width > rect.Height)
            {
                rect.X = rect.X + (rect.Width - rect.Height)/2;
                rect.Width = rect.Height;
            }

            if (rect.Width < rect.Height)
            {
                rect.Y = rect.Y + (rect.Height - rect.Width)/2;
                rect.Height = rect.Width;
            }

            return rect;
        }

        private void zgcSurveyPlot_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                _myPane.XAxis.Scale.FontSpec.Size = 12.0f;
                _myPane.YAxis.Scale.FontSpec.Size = 12.0f;
            }
            else
            {
                _myPane.XAxis.Scale.FontSpec.Size = 10.0f;
                _myPane.YAxis.Scale.FontSpec.Size = 10.0f;
            }
            var a = _myPane.CalcChartRect(zgcSurveyPlot.CreateGraphics());
            _myPane.Chart.Rect = GetEqualRatioRect(a);

        }

        private void GrabAllInputs()
        {
            SurveyDesign design;
            double bearing;
            switch ((SurveyDesign.DesignType) cboxMode.SelectedIndex)
            {
                case SurveyDesign.DesignType.SingleLine:

                    #region Case Single Line

                    design = new SurveyDesign(txtLineName.Text, Convert.ToDouble(numEasting.Value),
                        Convert.ToDouble(numNorthing.Value), Convert.ToDouble(numBearing.Value),
                        Convert.ToDouble(numInterval.Value), (int) numStation.Value);
                    break;
                    #endregion

                case SurveyDesign.DesignType.MultiLine:

                    #region Case Multi Line

                    switch (dropDownDirection.SelectedIndex)
                    {
                        case 1:
                            bearing = +90.0;
                            break;
                        default:
                            bearing = -90.0;
                            break;
                    }
                    design = new SurveyDesign(txtLineName.Text, Convert.ToDouble(numEasting.Value),
                        Convert.ToDouble(numNorthing.Value), Convert.ToDouble(numBearing.Value),
                        Convert.ToDouble(numInterval.Value), (int) numStation.Value, bearing,
                        (int) numMultiLineCount.Value, Convert.ToDouble(numMultiLineSpacing.Value));
                    break;

                    #endregion
                    
                case SurveyDesign.DesignType.FixedGrid:

                    #region Case Fixed Grid

                    switch (dropDownDirection.SelectedIndex)
                    {
                        case 1:
                            bearing = +90.0;
                            break;
                        default:
                            bearing = -90.0;
                            break;
                    }

                    design = new SurveyDesign(txtLineName.Text, Convert.ToDouble(numEasting.Value),
                        Convert.ToDouble(numNorthing.Value), Convert.ToDouble(numBearing.Value),
                        Convert.ToDouble(numInterval.Value), (int) numStation.Value, bearing,
                        (int) numMultiLineCount.Value);
                    break;

                    #endregion

                default:
                    design = null;
                    break;
            }

            if (design != null && design.Name == string.Empty) design.Name = "Undefined";
            _surveyFactory = new SurveyFactory(design);
        }

        
        private void SetLineStatus(SurveyDesign design)
        {
            switch (design.Type)
            {
                case SurveyDesign.DesignType.SingleLine:

                    #region case single

                    lblName.Text = design.Name;
                    lblType.Text = design.Type.ToString();
                    lblBearing.Text = string.Format("N {0}° E", design.Bearing);
                    lblSpacing.Text = string.Format("{0} m", design.Interval);
                    lblStations.Text = string.Format("{0} points", design.StationCount);

                    lblDistanceName.Text = @"Distance";
                    double distance = ((design.StationCount - 1)*design.Interval);
                    string unit = distance > 999 ? "Km" : "m";
                    distance = distance > 999 ? distance/1000 : distance;
                    lblDistance.Text = string.Format("{0} {1}", distance, unit);

                    #endregion

                    break;
                case SurveyDesign.DesignType.MultiLine:
                case SurveyDesign.DesignType.FixedGrid:

                    #region case multi or grid

                    lblName.Text = design.Name;
                    lblType.Text = string.Format("{0} ({1})", design.Type, design.LineCount);
                    lblBearing.Text = string.Format("N {0}° E", design.Bearing);
                    lblSpacing.Text = string.Format("{0} m / {1} m", design.Interval, design.LineSpacing);
                    lblStations.Text = string.Format("{0} points ({1} x {2})", design.StationCount*design.LineCount,
                        design.StationCount,
                        design.LineCount);


                    lblDistanceName.Text = @"Area";

                    double length = ((design.StationCount - 1)*design.Interval);
                    double height = ((design.LineCount - 1)*design.LineSpacing);
                    string lengthUnit = length > 999 ? "Km" : "m";
                    string heightUnit = height > 999 ? "Km" : "m";
                    length = lengthUnit == "Km" ? length/1000 : length;
                    height = heightUnit == "Km" ? height/1000 : height;

                    lblDistance.Text = string.Format("{0} {1} x {2} {3}", length, lengthUnit, height, heightUnit);
                    break;

                    #endregion

            }
        }

        private void SetLineStatus(string str)
        {
            lblName.Text = str;
            lblType.Text = str;
            lblBearing.Text = str;
            lblSpacing.Text = str;
            lblStations.Text = str;
            lblDistance.Text = str;
        }

        private void SetStatusBarText(string message)
        {
            toolStripStatusLabel1.Text = message;
            statusStrip1.Refresh();
        }

        private void DisableButtonOnWork(bool disable)
        {
            btnCreate.Enabled = !disable;
            btnNamingSetup.Enabled = !disable;
            saveToolStripMenuItem.Enabled = !disable;
        }

        private void DisableButtonOnLoad(bool disable)
        {
            saveToolStripMenuItem.Enabled = !disable;
            plotCurrentTableToolStripMenuItem.Enabled = !disable;
        }

        /// <summary>
        /// What Happen when generate button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            StartMainMethod();
        }

        /// <summary>
        /// Main method
        /// </summary>
        private void StartMainMethod()
        {
            GrabAllInputs();
            SetStatusBarText("Working.. Please wait..");
            toolStripProgressBar1.Visible = true;
            DisableButtonOnWork(true);

            backgroundWorker1.RunWorkerAsync();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cboxMode.SelectedIndex = 0;
            CueProvider.SetCue(txtLineName, "Enter a name here..");
            DisableButtonOnLoad(true);
            dropDownDirection.SelectedIndex = 0;
            SetLineStatus("-");
            SetStatusBarText("Ready.");
        }

//        private void btnMoreSetup_Click(object sender, EventArgs e)
//        {
//            var settings1 = new SettingsForm();
//
//            if (!string.IsNullOrEmpty(txtLineName.Text))
//            {
//                line1.Name = txtLineName.Text;
//            }
//
//            settings1.ReadSettings(line1, cboxMultiMode.Checked);
//
//            settings1.ShowDialog();
//
//            if (!settings1.ButtonSavePressed) return;
//
//            bool somethingChanged = settings1.IsSomethingChanged(line1);
//            settings1.SaveSettings(line1);
//
//            if (dgvCoordinates.DataSource != null && somethingChanged)
//            {
//                StartMainMethod();
//            }
//        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToTxt.ShowDialog();
        }

        //TODO: Implement saving
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            saveToTxt.FileName = string.Empty;
            SetStatusBarText("\tFile saved successfully.");
        }

        //TODO: Implement main worker
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = _surveyFactory.BuildSurveyPoints();
            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
                SetStatusBarText("Progress stopped.");
            }

            else
            {
                if (e.Cancelled)
                {
                    MessageBox.Show(@"Process cancelled");
                    SetStatusBarText("Progress cancelled.");
                }

                else
                {
                    var result = e.Result as SurveyPointList;
                    // ReSharper disable once PossibleNullReferenceException
                    dgvCoordinates.DataSource = result.ToList();
                    SetLineStatus(result.Design);
                    SetStatusBarText("Progress completed.");
                }
            }

            DisableButtonOnLoad(false);
            DisableButtonOnWork(false);
            toolStripProgressBar1.Visible = false;
            //          SetLineStatus(line1, cboxMultiMode.Checked);
                
            

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void latLongToUTMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement Coordinate Transform
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BetterDialog.ShowDialog("About SurveyLine", "SurveyLine v1.0",
                "This simple tool was developed in purpose to help designing a survey for Geophysical measurement or any other field measurement which requires a set of coordinates.\n\n" +
                "© 2014 Adien Akhmad. All rights reserved.", null, "Close",
                null);
        }

        private void txtLineName_Enter(object sender, EventArgs e)
        {
            if (MouseButtons != MouseButtons.None) return;
            txtLineName.SelectAll();
            _alreadyFocused = true;
        }

        private void txtLineName_MouseUp(object sender, MouseEventArgs e)
        {
            if (_alreadyFocused || txtLineName.SelectionLength != 0) return;
            _alreadyFocused = true;
            txtLineName.SelectAll();
        }

        private void txtLineName_Leave(object sender, EventArgs e)
        {
            _alreadyFocused = false;
        }

        private void txtLineName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Return))
            {
                SelectNextControl((Control) sender, true, true, true, true);
            }
        }

        private void NumOnFocus(object sender, EventArgs e)
        {
            var numControl = (NumericUpDown) sender;
            numControl.Select(0, numControl.Text.Length);
        }

        private void plotCurrentTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement the new plotting
        }

        private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            var dataObj = dgvCoordinates.GetClipboardContent();
            if (dataObj == null) return;
            Clipboard.SetDataObject(dataObj);
        }

        private void toolStripMenuItemCopyAll_Click(object sender, EventArgs e)
        {
            // set the columns to be able to be selected
            dgvCoordinates.ClearSelection();
            foreach (DataGridViewColumn c in dgvCoordinates.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dgvCoordinates.SelectionMode = DataGridViewSelectionMode.FullColumnSelect;

            // select all columns
            dgvCoordinates.RowHeadersVisible = false;
            
            foreach (DataGridViewColumn c in dgvCoordinates.Columns)
            {
                c.Selected = true;
            }

            // copy to clipboard
            var dataObj = dgvCoordinates.GetClipboardContent();
            if (dataObj == null) return;
            Clipboard.SetDataObject(dataObj);

            dgvCoordinates.RowHeadersVisible = true;

            // restore table behavior
            dgvCoordinates.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            foreach (DataGridViewColumn c in dgvCoordinates.Columns)
            {
                c.SortMode = DataGridViewColumnSortMode.Automatic;
            }
            
            // Finally a message.
            MessageBox.Show(@"Copied to clipboard.");
        }

        private void dgvCoordinates_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvCoordinates.SelectedCells.Count == 1)
                dgvCoordinates.CurrentCell = dgvCoordinates[e.ColumnIndex, e.RowIndex];
        }

        private void shortcutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,"SurveyLineHelp.chm");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "SurveyLineHelp.chm","Direction.htm");
        }

        private void btnMoreSetup_Click(object sender, EventArgs e)
        {

        }

        private void cboxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((SurveyDesign.DesignType)cboxMode.SelectedIndex)
            {
                case SurveyDesign.DesignType.SingleLine:

                    numMultiLineCount.Enabled = false;
                    numMultiLineSpacing.Enabled = false;
                    dropDownDirection.Enabled = false;

                    break;
                    

                case SurveyDesign.DesignType.MultiLine:

                    numMultiLineCount.Enabled = true;
                    numMultiLineSpacing.Enabled = true;
                    dropDownDirection.Enabled = true;
                    break;
                    

                case SurveyDesign.DesignType.FixedGrid:

                    numMultiLineCount.Enabled = true;
                    numMultiLineSpacing.Enabled = false;
                    dropDownDirection.Enabled = true;
                    break;
            }
        }

        
    }
}