using System;
using System.Windows.Forms;

namespace SurveyLine
{
    public partial class SettingsForm : Form
    {
        private string linename;
        private bool _multimode;

        public SettingsForm()
        {
            ButtonSavePressed = false;
            InitializeComponent();
        }

        public bool ButtonSavePressed { get; private set; }

        public void ReadSettings(LineMaker line, bool @checked)
        {
            this._multimode = @checked;
            this.numLineIndex.Enabled = this._multimode;
            this.txtLineSeparator.Enabled = this._multimode;

            this.linename = line.Name;
            this.numLineIndex.Value = line.LineIndex;
            this.txtLineSeparator.Text = line.LineSeparator;
            this.numStationsIndex.Value = line.StaIndex;
            this.txtStationsSeparator.Text = line.PointsSeparator;
            this.numDecimalPlaces.Value = line.DecimalPlaces;

            switch (line.Delimiter)
            {
                case "\t" :
                    this.cboxDelimiter.SelectedIndex = 0;
                    break;
                case "," :
                    this.cboxDelimiter.SelectedIndex = 1;
                    break;
                case " " :
                    this.cboxDelimiter.SelectedIndex = 2;
                    break;
            }
            
            UpdatePreview(this._multimode);
        }

        public bool IsSomethingChanged(LineMaker line)
        {
            return this.linename != line.Name || this.numLineIndex.Value != line.LineIndex || this.txtLineSeparator.Text != line.LineSeparator || this.numStationsIndex.Value != line.StaIndex || this.txtStationsSeparator.Text != line.PointsSeparator || this.numDecimalPlaces.Value != line.DecimalPlaces;
        }

        public void SaveSettings(LineMaker line)
        {
            line.LineIndex = (int) this.numLineIndex.Value;
            line.LineSeparator = this.txtLineSeparator.Text;
            line.StaIndex = (int) this.numStationsIndex.Value;
            line.PointsSeparator = this.txtStationsSeparator.Text;
            line.DecimalPlaces = (int) this.numDecimalPlaces.Value;

            switch (cboxDelimiter.SelectedIndex)
            {
                case 0:
                    line.Delimiter = "\t";
                    break;
                case 1:
                    line.Delimiter = ",";
                    break;
                case 2:
                    line.Delimiter = " ";
                    break;
            }


        }

        private void UpdatePreview(bool @multimode)
        {
            if (@multimode)
            {
                this.txtPreview.Text = string.Format("{0}{1}{2}{3}{4}",
                this.linename,
                this.txtLineSeparator.Text,
                this.numLineIndex.Value,
                this.txtStationsSeparator.Text,
                this.numStationsIndex.Value);
            }
            else
            {
                this.txtPreview.Text = string.Format("{0}{1}{2}",
                this.linename,
                this.txtStationsSeparator.Text,
                this.numStationsIndex.Value);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ButtonSavePressed = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numLineIndex_ValueChanged(object sender, EventArgs e)
        {
            this.UpdatePreview(this._multimode);
        }

        private void txtLineSeparator_TextChanged(object sender, EventArgs e)
        {
            this.UpdatePreview(this._multimode);
        }

        
    }
}
