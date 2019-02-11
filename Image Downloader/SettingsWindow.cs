using System;
using System.Windows.Forms;
using Image_Downloader.Properties;

namespace Image_Downloader
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
            UpdateTextboxes();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.Save();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void chkRequireLogin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTextboxes();
        }

        private void UpdateTextboxes()
        {
            if (chkRequireLogin.Checked)
            {
                tboxUsername.Enabled = true;
                tboxPassword.Enabled = true;
            }
            else
            {
                tboxUsername.Enabled = false;
                tboxPassword.Enabled = false;
            }
        }
    }
}