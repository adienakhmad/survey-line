using System;
using System.ComponentModel;
using System.Diagnostics;
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
        #region Field Declarations

        private SurveyFactory _surveyFactory;
        private GraphPane _myPane;
        
        #endregion

        public MainUI()
        {
            InitializeComponent();
            ZedGraphSetup();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {
            Size = new Size(630,530);
            cboxMode.SelectedIndex = 0;
            CueProvider.SetCue(txtLineName, "Enter a name here..");
            DisableButtonOnLoad(true);
            dropDownDirection.SelectedIndex = 0;
            SetLineStatus("-");
            SetStatusBarText("Ready.");
        }

        #region Zedgraph Plotting Behavior
        private double _xScaleMax, _xScaleMin, _yScaleMax, _yScaleMin;
        private PlotStyle _plottingStyle;

        /// <summary>
        /// Initial setup of Zedgraph Chart Control
        /// </summary>
        private void ZedGraphSetup()
        {
            _plottingStyle = new PlotStyle();
            _myPane = zgcSurveyPlot.GraphPane;
            _myPane.Chart.Border.Color = Color.Gray;
            _myPane.IsFontsScaled = false;
            _myPane.Title.IsVisible = false;
            _myPane.Title.Text = "";
            _myPane.Border.Color = Color.White;

            _myPane.YAxis.MajorGrid.IsVisible = true;
            _myPane.YAxis.MajorGrid.IsZeroLine = false;
            _myPane.YAxis.MajorGrid.Color = Color.Gray;
            _myPane.YAxis.Scale.FontSpec.Size = 10.0f;
            _myPane.YAxis.Scale.IsVisible = true;
            _myPane.YAxis.Title.IsVisible = false;
            _myPane.YAxis.Scale.MagAuto = false;
            _myPane.YAxis.MinorTic.IsAllTics = false;
            _myPane.YAxis.MajorTic.IsAllTics = true;
            _myPane.YAxis.MajorTic.Color = Color.Gray;
            _myPane.YAxis.Title.FontSpec.IsAntiAlias = false;
            _myPane.YAxis.Title.FontSpec.IsBold = true;
            _myPane.YAxis.Title.FontSpec.Size = 12f;
            _myPane.YAxis.Title.Text = "Y-Pos";
            _myPane.YAxis.Scale.MaxAuto = true;
            _myPane.YAxis.Scale.MinAuto = true;

            _myPane.XAxis.MajorGrid.IsVisible = true;
            _myPane.XAxis.MajorGrid.IsZeroLine = false;
            _myPane.XAxis.MajorGrid.Color = Color.Gray;
            _myPane.XAxis.Scale.FontSpec.Size = 10.0f;
            _myPane.XAxis.Scale.IsVisible = true;
            _myPane.XAxis.Scale.MagAuto = false;
            _myPane.XAxis.Title.IsVisible = false;
            _myPane.XAxis.MinorTic.IsAllTics = false;
            _myPane.XAxis.MajorTic.IsAllTics = true;
            _myPane.XAxis.MajorTic.Color = Color.Gray;
            _myPane.XAxis.Title.FontSpec.IsAntiAlias = false;
            _myPane.XAxis.Title.FontSpec.IsBold = true;
            _myPane.XAxis.Title.FontSpec.Size = 12f;
            _myPane.XAxis.Title.Text = "X-Pos";
            _myPane.XAxis.Scale.MaxAuto = true;
            _myPane.XAxis.Scale.MinAuto = true;

            _myPane.Legend.IsVisible = false;
            _myPane.AxisChangeEvent += graphPane_AxisChangeEvent;

            SetGraphScaleMaxMin(0,0,0,0);
        }

        /// <summary>
        /// Plot SurveyPointsList into Zedgraph Chart Object
        /// </summary>
        /// <param name="points"></param>
        /// <param name="style"></param>
        private void Plot(SurveyPointList points, PlotStyle style)
        {
            _myPane.Title.Text = points.Design.Name;
            _myPane.CurveList.Clear();
            _xScaleMax = Double.MinValue;
            _xScaleMin = Double.MaxValue;
            _yScaleMax = Double.MinValue;
            _yScaleMin = Double.MaxValue;

            var pointPairList = points.ToList();

            // TODO: consider re-design SurveyPointList to contain line
            for (int i = 0; i < points.Design.LineCount; i++)
            {
                var pointPairPlot = new PointPairList();
                for (int j = 0; j < points.Design.StationCount; j++)
                {
                    var x = pointPairList[j + (i*points.Design.StationCount)].X;
                    var y = pointPairList[j + (i*points.Design.StationCount)].Y;
                    var name = pointPairList[j + (i*points.Design.StationCount)].Name;

                    pointPairPlot.Add(x,y,name);

                    if (_xScaleMax < x)
                    {
                        _xScaleMax = x;
                    }
                    if (_xScaleMin > x)
                    {
                        _xScaleMin = x;
                    }
                    if (_yScaleMax < y)
                    {
                        _yScaleMax = y;
                    }
                    if (_yScaleMin > y)
                    {
                        _yScaleMin = y;
                    }
                }

                // TODO: Replace this plotting customization into its own class
                var myCurve = _myPane.AddCurve(points.Design.Name, pointPairPlot, style.LineColor);
                myCurve.Symbol = style.Marker;
                myCurve.Line.IsAntiAlias = style.IsAntiAlias;
                myCurve.Line.IsVisible = style.IsLineVisible;
            }

          SetGraphScaleMaxMin(_xScaleMin, _xScaleMax, _yScaleMin, _yScaleMax);
          _myPane.AxisChange();
          zgcSurveyPlot.Invalidate();
        }

        /// <summary>
        /// Set mypane maximum and minimum axis.
        /// </summary>
        /// <param name="xMin"></param>
        /// <param name="xMax"></param>
        /// <param name="yMin"></param>
        /// <param name="yMax"></param>
        private void SetGraphScaleMaxMin(double xMin, double xMax, double yMin, double yMax)
        {
            const double grace = 0.1;

            Debug.WriteLine(string.Format("See Max Min X:{0}\t{1}", xMin, xMax));
            Debug.WriteLine(string.Format("See Max Min Y:{0}\t{1}", yMin, yMax));

            xMin -= ((xMax - xMin)*grace);
            xMax += ((xMax - xMin)*grace);
            yMax += ((yMax - yMin)*grace);
            yMin -= ((yMax - yMin)*grace);

            _myPane.XAxis.Scale.Min = xMin;
            _myPane.XAxis.Scale.Max = xMax;
            _myPane.YAxis.Scale.Min = yMin;
            _myPane.YAxis.Scale.Max = yMax;

            Debug.WriteLine(string.Format("Set Max Min X:{0}\t{1}", _myPane.XAxis.Scale.Min, _myPane.XAxis.Scale.Max));
            Debug.WriteLine(string.Format("Set Max MinY:{0}\t{1}", _myPane.YAxis.Scale.Min, _myPane.YAxis.Scale.Max));
        }

/*
        /// <summary>
        /// Scales to 1:1 ratio with min size
        /// </summary>
        /// <param name="minSize"></param>
        void ScaleGraph(double minSize)
        {  
            double ratio;
            double xAxisCenter = (_myPane.XAxis.Scale.Max + _myPane.XAxis.Scale.Min) * 0.5;
            double yAxisCenter = (_myPane.YAxis.Scale.Max + _myPane.YAxis.Scale.Min) * 0.5;

            Debug.WriteLine(string.Format("X:{0}\t{1}", _myPane.XAxis.Scale.Min, _myPane.XAxis.Scale.Max));
            Debug.WriteLine(string.Format("Y:{0}\t{1}", _myPane.YAxis.Scale.Min, _myPane.XAxis.Scale.Max));
            Debug.WriteLine(string.Format("Rect:{0}\t{1}", _myPane.Chart.Rect.Height, _myPane.Chart.Rect.Width));

            zgcSurveyPlot.Refresh();

            if (_myPane.Chart.Rect.Height > _myPane.Chart.Rect.Width)
            {
                Debug.WriteLine(string.Format("Case Height > Widht"));
                ratio = _myPane.Chart.Rect.Height / _myPane.Chart.Rect.Width;

                _myPane.XAxis.Scale.Min = xAxisCenter - minSize * 0.5;
                _myPane.XAxis.Scale.Max = xAxisCenter + minSize * 0.5;

                _myPane.YAxis.Scale.Min = yAxisCenter - minSize * 0.5 * ratio;
                _myPane.YAxis.Scale.Max = yAxisCenter + minSize * 0.5 * ratio;
            }
            else
            {
                Debug.WriteLine(string.Format("Case Width > Height"));
                ratio = _myPane.Chart.Rect.Width / _myPane.Chart.Rect.Height;

                _myPane.YAxis.Scale.Min = yAxisCenter - minSize * 0.5;
                _myPane.YAxis.Scale.Max = yAxisCenter + minSize * 0.5;

                _myPane.XAxis.Scale.Min = xAxisCenter - minSize * 0.5 * ratio;
                _myPane.XAxis.Scale.Max = xAxisCenter + minSize * 0.5 * ratio;
            }
        }
*/
        private void graphPane_AxisChangeEvent(GraphPane pane)
        {
            SetScaleEqual();
        }

        /// <summary>
        /// Scales so the x-axis and y-axis have 1:1 ratio
        /// </summary>
        private void SetScaleEqual()
        {
            double scaleX2 = (_myPane.XAxis.Scale.Max - _myPane.XAxis.Scale.Min) / _myPane.Rect.Width;
            double scaleY2 = (_myPane.YAxis.Scale.Max - _myPane.YAxis.Scale.Min) / _myPane.Rect.Height;

            Debug.WriteLine(string.Format("Rect:{0}\t{1}", _myPane.Chart.Rect.Height, _myPane.Chart.Rect.Width));
            Debug.WriteLine(string.Format("Scale:{0}\t{1}", scaleX2, scaleY2));

            if (scaleX2 > scaleY2)
            {
                double diff = _myPane.YAxis.Scale.Max - _myPane.YAxis.Scale.Min;
                double newDiff = _myPane.Rect.Height * scaleX2;
                _myPane.YAxis.Scale.Min -= (newDiff - diff) / 2.0;
                _myPane.YAxis.Scale.Max += (newDiff - diff) / 2.0;


            }
            else if (scaleY2 > scaleX2)
            {
                double diff = _myPane.XAxis.Scale.Max - _myPane.XAxis.Scale.Min;
                double newDiff = _myPane.Rect.Width * scaleY2;
                _myPane.XAxis.Scale.Min -= (newDiff - diff) / 2.0;
                _myPane.XAxis.Scale.Max += (newDiff - diff) / 2.0;
            }

            // Recompute the grid lines
            float scaleFactor = _myPane.CalcScaleFactor();
            Graphics g = zgcSurveyPlot.CreateGraphics();
            _myPane.XAxis.Scale.PickScale(_myPane, g, scaleFactor);
            _myPane.YAxis.Scale.PickScale(_myPane, g, scaleFactor);
            
        }

/*
        /// <summary>
        /// Return an equl width and height of Chart Rectangle
        /// </summary>
        /// <param name="rect"></param>
        /// <returns></returns>
        private RectangleF GetEqualRatioRect(RectangleF rect)
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
*/

        private void zgcSurveyPlot_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                _myPane.XAxis.Scale.FontSpec.Size = 12.0f;
                _myPane.YAxis.Scale.FontSpec.Size = 12.0f;
                _myPane.Title.IsVisible = true;
                _myPane.XAxis.Title.IsVisible = true;
                _myPane.YAxis.Title.IsVisible = true;
            }
            else
            {
                _myPane.XAxis.Scale.FontSpec.Size = 10.0f;
                _myPane.YAxis.Scale.FontSpec.Size = 10.0f;
                _myPane.Title.IsVisible = false;
                _myPane.XAxis.Title.IsVisible = false;
                _myPane.YAxis.Title.IsVisible = false;
            }

            SetGraphScaleMaxMin(_xScaleMin, _xScaleMax, _yScaleMin, _yScaleMax);
            SetScaleEqual();

        }

        #endregion

        #region Main Methods

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
                    Plot(result, _plottingStyle);
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

        /// <summary>
        /// What Happen when generate button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            StartMainMethod();
        }

        #endregion

        #region UI Info Display

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

        #endregion

        #region UI Disable Enable Control Behavior

        private void DisableButtonOnWork(bool disable)
        {
            btnCreate.Enabled = !disable;
            btnNamingSetup.Enabled = !disable;
            saveToolStripMenuItem.Enabled = !disable;
        }

        private void DisableButtonOnLoad(bool disable)
        {
            saveToolStripMenuItem.Enabled = !disable;
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

        #endregion

        #region File Saving

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToTxt.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            saveToTxt.FileName = string.Empty;
            SetStatusBarText("\tFile saved successfully.");
        }

        #endregion

        #region All button click event
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BetterDialog.ShowDialog("About SurveyLine", "SurveyLine v1.0",
                "This simple tool was developed in purpose to help designing a survey for Geophysical measurement or any other field measurement which requires a set of coordinates.\n\n" +
                "© 2014 Adien Akhmad. All rights reserved.", null, "Close",
                null);
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

        private void toolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            var dataObj = dgvCoordinates.GetClipboardContent();
            if (dataObj == null) return;
            Clipboard.SetDataObject(dataObj);
        }

        private void latLongToUTMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: Implement Coordinate Transform
        }

        #endregion

        #region Survey Name Textbox Behavior
        private bool _alreadyFocused;
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
                SelectNextControl((Control)sender, true, true, true, true);
            }
        } 
        #endregion

        private void NumOnFocus(object sender, EventArgs e)
        {
            var numControl = (NumericUpDown) sender;
            numControl.Select(0, numControl.Text.Length);
        }

        private void dgvCoordinates_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvCoordinates.SelectedCells.Count == 1)
                dgvCoordinates.CurrentCell = dgvCoordinates[e.ColumnIndex, e.RowIndex];
        }

        private void label20_Click(object sender, EventArgs e)
        {
            Debug.WriteLine(string.Format("X:{0}\t{1}", _myPane.XAxis.Scale.Min, _myPane.XAxis.Scale.Max));
            Debug.WriteLine(string.Format("Y:{0}\t{1}", _myPane.YAxis.Scale.Min, _myPane.XAxis.Scale.Max));
        }
    }
}