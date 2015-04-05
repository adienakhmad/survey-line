using System;

namespace SurveyLineUI.Form
{
    public partial class SettingsForm : System.Windows.Forms.Form
    {
        private string _linename;
        private bool _multimode;

        public SettingsForm()
        {
            ButtonSavePressed = false;
            InitializeComponent();
        }

        public bool ButtonSavePressed { get; private set; }

        public void ReadSettings()
        {
            //TODO: Implement the new read settings
        }

        public void SaveSettings()
        {
            //TODO: Implement the new save settings


        }

        // Use this to update the preview name generator
        private void UpdatePreview(bool @multimode)
        {
            if (@multimode)
            {
                txtPreview.Text = string.Format("{0}{1}{2}{3}{4}",
                _linename,
                txtLineSeparator.Text,
                numLineIndex.Value,
                txtStationsSeparator.Text,
                numStationsIndex.Value);
            }
            else
            {
                txtPreview.Text = string.Format("{0}{1}{2}",
                _linename,
                txtStationsSeparator.Text,
                numStationsIndex.Value);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ButtonSavePressed = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numLineIndex_ValueChanged(object sender, EventArgs e)
        {
            UpdatePreview(_multimode);
        }

        private void txtLineSeparator_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview(_multimode);
        }

        
    }
}
