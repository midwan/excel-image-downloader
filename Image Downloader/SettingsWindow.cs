using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Properties.Settings.Default.Save();
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
