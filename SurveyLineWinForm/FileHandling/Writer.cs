using System.Globalization;
using System.Xml;
using SurveyLineWinForm;

namespace SurveyLineUI.FileHandling
{
    public static class Writer
    {
        public static void WriteSurveyLineDoc(string filename, PlotStyle style)
        {
            using (XmlWriter writer = XmlWriter.Create(filename))
            {
                writer.WriteStartDocument();

                writer.WriteStartElement("PlottingSettings");

                writer.WriteElementString("LineColor",style.LineColor.ToString());
                writer.WriteElementString("LineVisible",style.IsLineVisible.ToString());
                writer.WriteElementString("LineAntiAlias",style.IsAntiAlias.ToString());
                writer.WriteElementString("LineWidth",style.LineWidth.ToString(CultureInfo.InvariantCulture));
                writer.WriteElementString("MarkerSize",style.Marker.Size.ToString(CultureInfo.InvariantCulture));
                writer.WriteElementString("MarkerColor",style.Marker.Fill.Color.ToString());
                writer.WriteElementString("MarkerBorderVisible",style.Marker.Border.IsVisible.ToString());

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
