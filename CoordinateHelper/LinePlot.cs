using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace CoordinateHelper
{
    public partial class LinePlot : Form
    {
        private readonly double _xMin;
        private readonly double _xMax;
        private readonly double _yMin;
        private readonly double _yMax;
        public LinePlot(bool multiMode, string title, int stations, DataTable dtTable, double xMin, double xMax, double yMin, double yMax)
        {
            
            this._xMin = xMin;
            this._xMax = xMax;
            this._yMin = yMin;
            this._yMax = yMax;
            InitializeComponent();

            if (multiMode)
            {
                CreateMultiChart(title, stations, dtTable);
            }
            else
            {
                CreateSingleChart(title, dtTable);
            }
            zedGraphControl1.MasterPane[0].IsFontsScaled = false;
        }

        public void SetSize()
        {
            zedGraphControl1.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zedGraphControl1.Size = new Size(ClientRectangle.Width - 20,
                ClientRectangle.Height - 20);
        }

        public void CreateSingleChart(string title, DataTable dtTable)
        {
            GraphPane myPane = zedGraphControl1.GraphPane;
            // activate this if you need equal scaling of axis x and y
            myPane.AxisChangeEvent += graphPane_AxisChangeEvent;

            // Set the title and axis labels
            myPane.Title.Text = string.Format("{0} Plot", title);

            SetChartDisplay(myPane);
            SetChartFont(myPane);
            SetAxisLimit(myPane);


            var list1 = new PointPairList();

            foreach (DataRow drow in dtTable.Rows)
            {
                list1.Add((double) drow[1], (double) drow[2]);
            }

            LineItem myCurve = myPane.AddCurve(title, list1, Color.SlateBlue, SymbolType.Diamond);
            myCurve.Symbol.Fill = new Fill(Color.OrangeRed);
            myCurve.Symbol.Border.IsVisible = false;


            // Calculate the Axis Scale Ranges
            zedGraphControl1.AxisChange();
        }

        public void CreateMultiChart(string title, int stations, DataTable dtTable)
        {
            GraphPane myPane = zedGraphControl1.GraphPane;

            // activate this if you need equal scaling of axis x and y
            myPane.AxisChangeEvent += graphPane_AxisChangeEvent;

            // Set the title and axis labels
            myPane.Title.Text = string.Format("{0} Plot",title);
            myPane.Legend.IsVisible = false;

            SetChartDisplay(myPane);
            SetChartFont(myPane);
            SetAxisLimit(myPane);

            var myLineList = new List<PointPairList>();

            int countTracker = 0;

            var point = new PointPairList();
            foreach (DataRow dRow in dtTable.Rows)
            {
                countTracker++;
                point.Add((double) dRow[1], (double) dRow[2]);

                if (countTracker%stations != 0) continue;
                myLineList.Add(point);
                point = new PointPairList();
            }

            foreach (PointPairList pointList in myLineList)
            {
                LineItem myCurve = myPane.AddCurve(title, pointList, Color.SlateBlue, SymbolType.Diamond);
                myCurve.Symbol.Fill = new Fill(Color.OrangeRed);
                myCurve.Symbol.Border.IsVisible = false;
            }

            // Calculate the Axis Scale Ranges
            zedGraphControl1.AxisChange();
        }

        private void graphPane_AxisChangeEvent(GraphPane target)
        {
            SetSize();
            GraphPane graphPane = zedGraphControl1.GraphPane;

            // Correct the scale so that the two axes are 1:1 aspect ratio
            double scaleX2 = (graphPane.XAxis.Scale.Max - graphPane.XAxis.Scale.Min)/graphPane.Rect.Width;
            double scaleY2 = (graphPane.YAxis.Scale.Max - graphPane.YAxis.Scale.Min)/graphPane.Rect.Height;
            if (scaleX2 > scaleY2)
            {
                double diff = graphPane.YAxis.Scale.Max - graphPane.YAxis.Scale.Min;
                double newDiff = graphPane.Rect.Height*scaleX2;
                graphPane.YAxis.Scale.Min -= (newDiff - diff)/2.0;
                graphPane.YAxis.Scale.Max += (newDiff - diff)/2.0;
            }
            else if (scaleY2 > scaleX2)
            {
                double diff = graphPane.XAxis.Scale.Max - graphPane.XAxis.Scale.Min;
                double new_diff = graphPane.Rect.Width*scaleY2;
                graphPane.XAxis.Scale.Min -= (new_diff - diff)/2.0;
                graphPane.XAxis.Scale.Max += (new_diff - diff)/2.0;
            }

            // Recompute the grid lines
            float scaleFactor = graphPane.CalcScaleFactor();
            Graphics g = zedGraphControl1.CreateGraphics();
            graphPane.XAxis.Scale.PickScale(graphPane, g, scaleFactor);
            graphPane.YAxis.Scale.PickScale(graphPane, g, scaleFactor);
        }

        private void zedGraphControl1_Resize(object sender, EventArgs e)
        {
            SetAxisLimit(zedGraphControl1.GraphPane);
            zedGraphControl1.AxisChange();
        }

        private void SetChartFont(GraphPane myPane)
        {
            const string fontFamily = "Tahoma";
            myPane.Title.FontSpec.Size = 14;
            myPane.Title.FontSpec.IsBold = true;
            myPane.Title.FontSpec.Family = fontFamily;

            myPane.XAxis.Title.FontSpec.Family = fontFamily;
            myPane.XAxis.Title.FontSpec.IsBold = true;
            myPane.XAxis.Title.FontSpec.Size = 12.0f;
            myPane.XAxis.Scale.FontSpec.Family = fontFamily;
            myPane.XAxis.Scale.FontSpec.Size = 12.0f;

            myPane.YAxis.Title.FontSpec.Family = fontFamily;
            myPane.YAxis.Title.FontSpec.IsBold = true;
            myPane.YAxis.Title.FontSpec.Size = 12.0f;
            myPane.YAxis.Scale.FontSpec.Family = fontFamily;
            myPane.YAxis.Scale.FontSpec.Size = 12.0f;
        }

        private void SetChartDisplay(GraphPane myPane)
        {
            myPane.XAxis.Title.Text = "Easting";
            myPane.XAxis.Scale.MagAuto = false;    
            myPane.XAxis.MajorGrid.IsVisible = true;
            
            myPane.YAxis.Title.Text = "Northing";
            myPane.YAxis.Scale.MagAuto = false;
            myPane.YAxis.MajorGrid.IsVisible = true;
        }

        private void SetAxisLimit(GraphPane myPane)
        {
            myPane.XAxis.Scale.MinAuto = false;
            myPane.XAxis.Scale.Min = _xMin;
            myPane.XAxis.Scale.MaxAuto = false;
            myPane.XAxis.Scale.Max = _xMax;

            myPane.YAxis.Scale.MaxAuto = false;
            myPane.YAxis.Scale.Max = _yMax;
            myPane.YAxis.Scale.MinAuto = false;
            myPane.YAxis.Scale.Min = _yMin;
        }
    }
}