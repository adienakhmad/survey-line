using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace CoordinateHelper
{
    public partial class LinePlot : Form
    {
        private GraphPane myPane;

        public LinePlot()
        {
            InitializeComponent();
            myPane = zedGraphControl1.GraphPane;

            // activate this if you need equal scaling of axis x and y
            myPane.AxisChangeEvent += new GraphPane.AxisChangeEventHandler(graphPane_AxisChangeEvent);
            
        }

        public void SetSize()
        {
            zedGraphControl1.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zedGraphControl1.Size = new Size(ClientRectangle.Width - 20,
                                    ClientRectangle.Height - 20);
        }

        public void CreateSingleChart(string title, DataTable dtTable,double xmin, double xmax, double ymin, double ymax)
        {

            // Set the title and axis labels
            myPane.Title.Text = title;

            myPane.XAxis.Title.Text = "Easting";
            myPane.XAxis.Scale.MagAuto = false;
            myPane.XAxis.Scale.MaxAuto = false;
            myPane.XAxis.Scale.Max = xmax;
            myPane.XAxis.Scale.MinAuto = false;
            myPane.XAxis.Scale.Min = xmin;
            myPane.XAxis.MajorGrid.IsVisible = true;

            myPane.YAxis.Title.Text = "Northing";
            myPane.YAxis.Scale.MagAuto = false;
            myPane.YAxis.Scale.MaxAuto = false;
            myPane.YAxis.Scale.Max = ymax;
            myPane.YAxis.Scale.MinAuto = false;
            myPane.YAxis.Scale.Min = ymin;
            myPane.YAxis.MajorGrid.IsVisible = true;



            // Make up some data arrays based on the Sine function
            PointPairList list1 = new PointPairList();

            foreach (DataRow drow in dtTable.Rows)
            {
                list1.Add((double)drow[1],(double)drow[2]);
            }

            // Generate a red curve with diamond
            // symbols, and "Porsche" in the legend
            
                LineItem myCurve = myPane.AddCurve(title,list1, Color.Red, SymbolType.Diamond);
            
            

            // Calculate the Axis Scale Ranges
            zedGraphControl1.AxisChange();

        }

        public void CreateMultiChart(string title, int stations,DataTable dtTable, double xmin, double xmax, double ymin, double ymax)
        {
            // Set the title and axis labels
            myPane.Title.Text = title;
            myPane.Legend.IsVisible = false;

            myPane.XAxis.Title.Text = "Easting";
            myPane.XAxis.Scale.MagAuto = false;
            myPane.XAxis.Scale.MaxAuto = false;
            myPane.XAxis.Scale.Max = xmax;
            myPane.XAxis.Scale.MinAuto = false;
            myPane.XAxis.Scale.Min = xmin;
            myPane.XAxis.MajorGrid.IsVisible = true;

            myPane.YAxis.Title.Text = "Northing";
            myPane.YAxis.Scale.MagAuto = false;
            myPane.YAxis.Scale.MaxAuto = false;
            myPane.YAxis.Scale.Max = ymax;
            myPane.YAxis.Scale.MinAuto = false;
            myPane.YAxis.Scale.Min = ymin;
            myPane.YAxis.MajorGrid.IsVisible = true;



            // Make up some data arrays based on the Sine function
            List <PointPairList> myLineList = new List <PointPairList>();
            
         
            var countTracker = 0;

            var point = new PointPairList();
            foreach (DataRow dRow in dtTable.Rows)
            {
                countTracker++;
                point.Add((double)dRow[1], (double)dRow[2]);

                if (countTracker % stations == 0)
                {
                    myLineList.Add(point);
                    point = new PointPairList();
                }
            }

            foreach (var pointList in myLineList)
            {
                LineItem myCurve = myPane.AddCurve(title, pointList, Color.Red, SymbolType.Diamond);
            }

            
            // Calculate the Axis Scale Ranges
            zedGraphControl1.AxisChange();
        }
        private void graphPane_AxisChangeEvent(GraphPane target)
        {
            SetSize();
            GraphPane graphPane = zedGraphControl1.GraphPane;

            // Correct the scale so that the two axes are 1:1 aspect ratio
            double scalex2 = (graphPane.XAxis.Scale.Max - graphPane.XAxis.Scale.Min) / graphPane.Rect.Width;
            double scaley2 = (graphPane.YAxis.Scale.Max - graphPane.YAxis.Scale.Min) / graphPane.Rect.Height;
            if (scalex2 > scaley2)
            {
                double diff = graphPane.YAxis.Scale.Max - graphPane.YAxis.Scale.Min;
                double new_diff = graphPane.Rect.Height * scalex2;
                graphPane.YAxis.Scale.Min -= (new_diff - diff) / 2.0;
                graphPane.YAxis.Scale.Max += (new_diff - diff) / 2.0;
            }
            else if (scaley2 > scalex2)
            {
                double diff = graphPane.XAxis.Scale.Max - graphPane.XAxis.Scale.Min;
                double new_diff = graphPane.Rect.Width * scaley2;
                graphPane.XAxis.Scale.Min -= (new_diff - diff) / 2.0;
                graphPane.XAxis.Scale.Max += (new_diff - diff) / 2.0;
            }

            // Recompute the grid lines
            float scaleFactor = graphPane.CalcScaleFactor();
            Graphics g = zedGraphControl1.CreateGraphics();
            graphPane.XAxis.Scale.PickScale(graphPane, g, scaleFactor);
            graphPane.YAxis.Scale.PickScale(graphPane, g, scaleFactor);
        }

        private void zedGraphControl1_Resize(object sender, EventArgs e)
        {
            zedGraphControl1.AxisChange();
        }
    }
}
