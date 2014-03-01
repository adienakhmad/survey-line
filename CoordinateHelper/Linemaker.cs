/*
 * Created by SharpDevelop.
 * User: SamsungNC108
 * Date: 2/14/2014
 * Time: 12:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Data;

namespace CoordinateHelper
{
	/// <summary>
	/// Description of Line.
	/// </summary>
	public class Linemaker
	{
	    
	    public string Name { get; set; }

	    public double Xstart { get; set; }

	    public double Ystart { get; set; }

	    public double Bearing { get; set; }

	    public double Interval { get; set; }

	    public int Station { get; set; }

	    public double DisplacementX { get; set; }

	    public double DisplacementY { get; set; }

	    public int Linecount { get; set; }

        public double LineSpacing { get; set; }

	    public string Type { get; set; }

	    public double PlusBearing { get; set; }

	    public string Lineseparator { get; set; }

	    public string Pointseparator { get; set; }

	    public string Delimiter { get; set; }

        public int StaIndex { get; set; }

	    public int LineIndex { get; set; }

        public int DecimalPlaces { get; set; }

	    public string NumericFormat
	    {
            get { return string.Format("F{0}", DecimalPlaces); }
	    }
        

	    public Linemaker()
	    {
	        Name = "Unnamed";
	        StaIndex = 1;
	        LineIndex = 1;
	        Delimiter = "\t";
	        Lineseparator = "-";
	        Pointseparator = "-";
	        DecimalPlaces = 2;
	    }

	    public DataTable GenerateTable(bool multimode)
	    {
            var dtable = new DataTable();
	        DataColumn dcolumn;
	        DataRow drow;

            // first column
            dcolumn = new DataColumn
            {
                DataType = System.Type.GetType("System.String"),
                ColumnName = "Stations",
                ReadOnly = true,
                Unique = true
            };
	        dtable.Columns.Add(dcolumn);

            // second column
            dcolumn = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "X-Coor",
                ReadOnly = true,
                Unique = false
            };
	        dtable.Columns.Add(dcolumn);

            // third column
            dcolumn = new DataColumn
            {
                DataType = System.Type.GetType("System.Double"),
                ColumnName = "Y-Coor",
                ReadOnly = true,
                Unique = false
            };
	        dtable.Columns.Add(dcolumn);

            this.DisplacementX = Interval * Math.Sin(Bearing * (Math.PI / 180.0f));
            this.DisplacementY = Interval * Math.Cos(Bearing * (Math.PI / 180.0f));

	        var staLeadingZeros = string.Format("D{0}",Station.ToString().Length);
	        var lineLeadingZeros = string.Format("D{0}", Linecount.ToString().Length);

	        if (multimode)
	        {
                
	            var directionChange = this.Bearing + this.PlusBearing;
                var lineIndex = this.LineIndex;

	            for (var i = 0; i < Linecount; i++)
	            {
	                var pointindex = this.StaIndex;
	                var xbegin = this.Xstart + (i*(this.LineSpacing*Math.Sin(directionChange*(Math.PI/180.0f))));
	                var ybegin = this.Ystart + (i*(this.LineSpacing*Math.Cos(directionChange*(Math.PI/180.0f))));

	                for (var j = 0; j < Station; j++)
                    {
                        drow = dtable.NewRow();
                        drow[0] = string.Format("{0}{1}{2}{3}{4}", this.Name,this.Lineseparator,lineIndex.ToString(lineLeadingZeros), this.Pointseparator, pointindex.ToString(staLeadingZeros));
                        drow[1] = xbegin;
                        drow[2] = ybegin;
                        dtable.Rows.Add(drow);
                        xbegin += this.DisplacementX;
                        ybegin += this.DisplacementY;
                        pointindex++;
                    }

                    
	                lineIndex++;

	            }
	        }

	        else
	        {
	            var pointindex = this.StaIndex;
                for (var i = 0; i < Station; i++)
                {
                    drow = dtable.NewRow();
                    drow[0] = string.Format("{0}{1}{2}", this.Name, this.Pointseparator, pointindex.ToString(staLeadingZeros));
                    drow[1] = this.Xstart;
                    drow[2] = this.Ystart;
                    dtable.Rows.Add(drow);
                    this.Xstart += this.DisplacementX;
                    this.Ystart += this.DisplacementY;
                    pointindex++;
                }
	        }

     

	        return dtable;
	    }

	  
	}
}
