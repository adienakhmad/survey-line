using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using ZedGraph;

namespace SurveyLineWinForm
{
    class PlotStyle
    {
        public Color LineColor { get; set; }
        public Symbol Marker { get; set; }
        public bool IsAntiAlias { get; set; }
        public bool IsLineVisible { get; set; }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        /// <param name="lineColor"></param>
        /// <param name="lineVisible"></param>
        /// <param name="antialias"></param>
        /// <param name="markerType"></param>
        /// <param name="markerColor"></param>
        /// <param name="markerSize"></param>
        public PlotStyle(Color lineColor, bool lineVisible, bool antialias, SymbolType markerType, Color markerColor, float markerSize, bool markerBorder)
        {
            LineColor = lineColor;
            IsLineVisible = lineVisible;
            IsAntiAlias = antialias;
            Marker = new Symbol
            {
                Fill = new Fill(markerColor),
                Type = markerType,
                Size = markerSize,
                Border = new Border() { IsVisible = markerBorder}
            };
        }

        public PlotStyle()
        {
            LineColor = Color.Gainsboro;
            IsLineVisible = true;
            IsAntiAlias = true;
            Marker = new Symbol()
            {
                Fill = new Fill(Color.OrangeRed),
                Type = SymbolType.Square,
                Size = 5.0f,
                Border = new Border() { IsVisible = false}
                
            };
            

        }
    }
}
