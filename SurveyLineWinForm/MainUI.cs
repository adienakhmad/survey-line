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
        public MainUI()
        {
            InitializeComponent();
            ZedGraphSetup();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Size = new Size(640, 530);
            cboxMode.SelectedIndex = 0;
            CueProvider.SetCue(txtLineName, "Enter a name here..");
            DisableButtonOnLoad(true);
            dropDownDirection.SelectedIndex = 0;
            SetLineStatus("-");
            SetStatusBarText("Ready.");
        }

        #region Field Declarations

        private SurveyFactory _surveyFactory;
        private GraphPane _myPane;

        #endregion

        #region Main Methods

        private void GrabAllInputs()
        {
            SurveyDesign design;
            double bearing;
            switch ((SurveyDesign.DesignType)cboxMode.SelectedIndex)
            {
                case SurveyDesign.DesignType.SingleLine:

                    #region Case Single Line

                    design = new SurveyDesign(txtLineName.Text, Convert.ToDouble(numEasting.Value),
                        Convert.ToDouble(numNorthing.Value), Convert.ToDouble(numBearing.Value),
                        Convert.ToDouble(numInterval.Value), (int)numStation.Value);
                    break;

                    #endregion

                case SurveyDesign.DesignType.MultiLine:

                    #region Case Multi Line

                    switch (dropDownDirection.SelectedIndex)
                    {
                        case 0:
                            bearing = +90.0;
                            break;
                        default:
                            bearing = -90.0;
                            break;
                    }
                    design = new SurveyDesign(txtLineName.Text, Convert.ToDouble(numEasting.Value),
                        Convert.ToDouble(numNorthing.Value), Convert.ToDouble(numBearing.Value),
                        Convert.ToDouble(numInterval.Value), (int)numStation.Value, bearing,
                        (int)numMultiLineCount.Value, Convert.ToDouble(numMultiLineSpacing.Value));
                    break;

                    #endregion

                case SurveyDesign.DesignType.RectangularGrid:

                    #region Case RectangularGrid

                    switch (dropDownDirection.SelectedIndex)
                    {
                        case 0:
                            bearing = +90.0;
                            break;
                        default:
                            bearing = -90.0;
                            break;
                    }

                    design = new SurveyDesign(txtLineName.Text, Convert.ToDouble(numEasting.Value),
                        Convert.ToDouble(numNorthing.Value), Convert.ToDouble(numBearing.Value),
                        Convert.ToDouble(numInterval.Value), (int)numStation.Value,
                        (int)numMultiLineCount.Value, bearing);
                    break;

                    #endregion

                case SurveyDesign.DesignType.SquareGrid:
                    #region Case SquareGrid

                    switch (dropDownDirection.SelectedIndex)
                    {
                        case 0:
                            bearing = +90.0;
                            break;
                        default:
                            bearing = -90.0;
                            break;
                    }

                    design = new SurveyDesign(txtLineName.Text, Convert.ToDouble(numEasting.Value),
                        Convert.ToDouble(numNorthing.Value), Convert.ToDouble(numBearing.Value),
                        Convert.ToDouble(numInterval.Value), (int)numStation.Value, bearing);
                    break;

                    #endregion

                default:
                    design = null;
                    break;
            }
            _surveyFactory = new SurveyFactory(design);
        }

        /// <summary>
        ///     Main method
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
                    var result = e.Result as StationListContainer;
                    Plot(result, _plottingStyle);
                    tabControl1.SelectedTab = tabPagePlot;
                    // ReSharper disable once PossibleNullReferenceException
                    dgvCoordinates.DataSource = result.GetAllStations();
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
        ///     What Happen when generate button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreate_Click(object sender, EventArgs e)
        {
            StartMainMethod();
        }

        #endregion

        #region Zedgraph Plotting Behavior

        private double _xScaleMax, _xScaleMin, _yScaleMax, _yScaleMin;
        private PlotStyle _plottingStyle;

        /// <summary>
        ///     Initial setup of Zedgraph Chart Control
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

            SetGraphScaleMaxMin(0, 0, 0, 0);
        }

        /// <summary>
        ///     Plot StationListContainer into Zedgraph Chart Object
        /// </summary>
        /// <param name="container"></param>
        /// <param name="style"></param>
        private void Plot(StationListContainer container, PlotStyle style)
        {
            _myPane.Title.Text = container.Design.Name;
            _myPane.CurveList.Clear();
            _xScaleMax = Double.MinValue;
            _xScaleMin = Double.MaxValue;
            _yScaleMax = Double.MinValue;
            _yScaleMin = Double.MaxValue;


            foreach (var line in container.Lines)
            {
                var pointPairPlot = new PointPairList();
                foreach (var station in line.GetStations())
                {
                    pointPairPlot.Add(station.X, station.Y, station.Name);

                    // Find maximum and minimum (X, Y)
                    if (_xScaleMax < station.X)
                    {
                        _xScaleMax = station.X;
                    }
                    if (_xScaleMin > station.X)
                    {
                        _xScaleMin = station.X;
                    }
                    if (_yScaleMax < station.Y)
                    {
                        _yScaleMax = station.Y;
                    }
                    if (_yScaleMin > station.Y)
                    {
                        _yScaleMin = station.Y;
                    }
                }

                var myCurve = _myPane.AddCurve(container.Design.Name, pointPairPlot, style.LineColor);
                myCurve.Symbol = style.Marker;
                myCurve.Line.IsAntiAlias = style.IsAntiAlias;
                myCurve.Line.IsVisible = style.IsLineVisible;
            }

            SetGraphScaleMaxMin(_xScaleMin, _xScaleMax, _yScaleMin, _yScaleMax);
            _myPane.AxisChange();
            zgcSurveyPlot.Invalidate();
        }

        /// <summary>
        ///     Set mypane maximum and minimum axis.
        /// </summary>
        /// <param name="xMin"></param>
        /// <param name="xMax"></param>
        /// <param name="yMin"></param>
        /// <param name="yMax"></param>
        private void SetGraphScaleMaxMin(double xMin, double xMax, double yMin, double yMax)
        {
            const double grace = 0.1;
            
            xMin -= ((xMax - xMin)*grace);
            xMax += ((xMax - xMin)*grace);
            yMax += ((yMax - yMin)*grace);
            yMin -= ((yMax - yMin)*grace);

            _myPane.XAxis.Scale.Min = xMin;
            _myPane.XAxis.Scale.Max = xMax;
            _myPane.YAxis.Scale.Min = yMin;
            _myPane.YAxis.Scale.Max = yMax;

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
        ///     Scales so the x-axis and y-axis have 1:1 ratio
        /// </summary>
        private void SetScaleEqual()
        {
            var scaleX2 = (_myPane.XAxis.Scale.Max - _myPane.XAxis.Scale.Min)/_myPane.Rect.Width;
            var scaleY2 = (_myPane.YAxis.Scale.Max - _myPane.YAxis.Scale.Min)/_myPane.Rect.Height;

            if (scaleX2 > scaleY2)
            {
                var diff = _myPane.YAxis.Scale.Max - _myPane.YAxis.Scale.Min;
                var newDiff = _myPane.Rect.Height*scaleX2;
                _myPane.YAxis.Scale.Min -= (newDiff - diff)/2.0;
                _myPane.YAxis.Scale.Max += (newDiff - diff)/2.0;
            }
            else if (scaleY2 > scaleX2)
            {
                var diff = _myPane.XAxis.Scale.Max - _myPane.XAxis.Scale.Min;
                var newDiff = _myPane.Rect.Width*scaleY2;
                _myPane.XAxis.Scale.Min -= (newDiff - diff)/2.0;
                _myPane.XAxis.Scale.Max += (newDiff - diff)/2.0;
            }

            // Recompute the grid lines
            var scaleFactor = _myPane.CalcScaleFactor();
            var g = zgcSurveyPlot.CreateGraphics();
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
            _myPane.AxisChange();
        }

        #endregion

        #region UI Info Display

        private void SetLineStatus(SurveyDesign design)
        {
            double length;
            double height;
            string lengthUnit;
            string heightUnit;
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
                    var distance = ((design.StationCount - 1)*design.Interval);
                    var unit = distance > 999 ? "Km" : "m";
                    distance = distance > 999 ? distance/1000 : distance;
                    lblDistance.Text = string.Format("{0} {1}", distance, unit);

                    #endregion

                    break;
                case SurveyDesign.DesignType.MultiLine:

                    #region case multiline

                    lblName.Text = design.Name;
                    lblType.Text = string.Format("{0} ({1})", design.Type, design.LineCount);
                    lblBearing.Text = string.Format("N {0}° E", design.Bearing);
                    lblSpacing.Text = string.Format("{0} m / {1} m", design.Interval, design.LineSpacing);
                    lblStations.Text = string.Format("{0} points ({1} x {2})", design.StationCount*design.LineCount,
                        design.StationCount,
                        design.LineCount);


                    lblDistanceName.Text = @"Area";

                    length = ((design.StationCount - 1)*design.Interval);
                    height = ((design.LineCount - 1)*design.LineSpacing);
                    lengthUnit = length > 999 ? "Km" : "m";
                    heightUnit = height > 999 ? "Km" : "m";
                    length = lengthUnit == "Km" ? length/1000 : length;
                    height = heightUnit == "Km" ? height/1000 : height;

                    lblDistance.Text = string.Format("{0} {1} x {2} {3}", length, lengthUnit, height, heightUnit);
                    break;

                    #endregion

                case SurveyDesign.DesignType.RectangularGrid:
                case SurveyDesign.DesignType.SquareGrid:

                    #region case grid

                    lblName.Text = design.Name;
                    lblType.Text = string.Format("{0}", design.Type);
                    lblBearing.Text = string.Format("N {0}° E", design.Bearing);
                    lblSpacing.Text = string.Format("{0} m", design.Interval);
                    lblStations.Text = string.Format("{0} points ({1} x {1})", design.StationCount*design.StationCount,
                        design.StationCount);


                    lblDistanceName.Text = @"Area";

                    length = ((design.StationCount - 1)*design.Interval);
                    height = ((design.LineCount - 1)*design.LineSpacing);
                    lengthUnit = length > 999 ? "Km" : "m";
                    heightUnit = height > 999 ? "Km" : "m";
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
            switch ((SurveyDesign.DesignType) cboxMode.SelectedIndex)
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


                case SurveyDesign.DesignType.RectangularGrid:

                    numMultiLineCount.Enabled = true;
                    numMultiLineSpacing.Enabled = false;
                    dropDownDirection.Enabled = true;
                    break;

                case SurveyDesign.DesignType.SquareGrid:

                    numMultiLineCount.Enabled = false;
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
            BetterDialog.ShowDialog("About Survey Line", "Survey Line v2.0",
                "This simple tool was developed in purpose to help designing a survey for Geophysical measurement or any other field measurement which requires a set of coordinates.\n\n" +
                "Copyright © 2014-2015 Adien Akhmad.", null, "Close",
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
            Help.ShowHelp(this, "SurveyLineHelp.chm");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "SurveyLineHelp.chm", "Direction.htm");
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
                SelectNextControl((Control) sender, true, true, true, true);
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

        #region Plot Customization Control

        private void buttonLineColor_Click(object sender, EventArgs e)
        {
            var dlgresult = lineColorDialog.ShowDialog();

            if (dlgresult == DialogResult.OK)
            {
                buttonLineColor.BackColor = lineColorDialog.Color;
            }
        }

        private void buttonMarkerColor_Click(object sender, EventArgs e)
        {
            var dlgresult = markerColorDialog.ShowDialog();

            if (dlgresult == DialogResult.OK)
            {
                buttonMarkerColor.BackColor = markerColorDialog.Color;
            }
        }

        #endregion

        #region Easting Northing Context Menu Behavior

        private void cmNumButton_Opening(object sender, CancelEventArgs e)
        {
            var controlSender = sender as ContextMenuStrip;
            if (controlSender == null) return;
            if (!Clipboard.ContainsText())
            {
                tsmPasteXY.Enabled = false;
                tsmPaste.Enabled = false;
            }
            else
            {
                tsmPasteXY.Enabled = true;
                tsmPaste.Enabled = true;
            }
            var controlOwner = controlSender.SourceControl as NumericUpDown;
            if (controlOwner == null) return;
            controlOwner.Select();
            controlOwner.Select(0, controlOwner.Text.Length);
        }

        private void tsmCopy_Click(object sender, EventArgs e)
        {
            var tsm = sender as ToolStripMenuItem;
            if (tsm == null) return;
            var cms = tsm.Owner as ContextMenuStrip;
            if (cms == null) return;
            var nup = cms.SourceControl as NumericUpDown;

            if (nup != null) Clipboard.SetText(nup.Text);
        }

        private void tsmCut_Click(object sender, EventArgs e)
        {
            var tsm = sender as ToolStripMenuItem;
            if (tsm == null) return;
            var cms = tsm.Owner as ContextMenuStrip;
            if (cms == null) return;
            var nup = cms.SourceControl as NumericUpDown;
            if (nup == null) return;

            Clipboard.SetText(nup.Text);
            nup.Text = String.Empty;
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            var tsm = sender as ToolStripMenuItem;
            if (tsm == null) return;
            var cms = tsm.Owner as ContextMenuStrip;
            if (cms == null) return;
            var nup = cms.SourceControl as NumericUpDown;
            if (nup == null) return;

            nup.Text = String.Empty;
        }

        private void tsmPaste_Click(object sender, EventArgs e)
        {
            var tsm = sender as ToolStripMenuItem;
            if (tsm == null) return;
            var cms = tsm.Owner as ContextMenuStrip;
            if (cms == null) return;
            var nup = cms.SourceControl as NumericUpDown;
            if (nup == null) return;

            if (Clipboard.ContainsText())
            {
                nup.Text = Clipboard.GetText();
            }
        }

        private void tsmPasteXY_Click(object sender, EventArgs e)
        {
            if (!Clipboard.ContainsText()) return;
            var text = Clipboard.GetText();
            var delimiter = new[] {'\t', ' ', ',',';'};
            var splitted = text.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);

            if (splitted.Length == 2)
            {
                Decimal easting;
                Decimal northing;

                if (Decimal.TryParse(splitted[0], out easting) && Decimal.TryParse(splitted[1], out northing))
                {
                    numEasting.Value = Decimal.Parse(splitted[0]);
                    numNorthing.Value = Decimal.Parse(splitted[1]);
                }
                else 
                    MessageBox.Show(@"The text you are trying to paste is not a valid coordinate.");
            }

            else
                MessageBox.Show(@"The text you are trying to paste is not a valid coordinate.");
        }

        #endregion

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("survey-line.exe");
        }

    }
}