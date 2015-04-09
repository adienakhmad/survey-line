using System.Drawing;
using ZedGraph;

namespace SurveyLineWinForm
{
    public class PlotStyle
    {
        //TODO: Make this class in sync with plotting style control
        public Color LineColor { get; set; }
        public float LineWidth { get; set; }
        public Symbol Marker { get; set; }
        public bool IsAntiAlias { get; set; }
        public bool IsLineVisible { get; set; }

        /// <summary>
        /// Create a plot style class
        /// </summary>
        /// <param name="lineColor"></param>
        /// <param name="isLineVisible"></param>
        /// <param name="isLineAntiAlias"></param>
        /// <param name="markerType"></param>
        /// <param name="markerColor"></param>
        /// <param name="lineWidth"></param>
        /// <param name="markerSize"></param>
        /// <param name="isBorderVisible"></param>
        public PlotStyle(Color lineColor, bool isLineVisible, bool isLineAntiAlias, SymbolType markerType, Color markerColor, float lineWidth, float markerSize, bool isBorderVisible)
        {
            LineColor = lineColor;
            LineWidth = lineWidth;
            IsLineVisible = isLineVisible;
            IsAntiAlias = isLineAntiAlias;
            Marker = new Symbol
            {
                IsVisible = isBorderVisible,
                Fill = new Fill(markerColor),
                Type = markerType,
                Size = markerSize,
                Border = new Border() { IsVisible = false}
            };
        }

        public PlotStyle()
        {
            LineColor = Color.Gainsboro;
            LineWidth = 5.0f;
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
