namespace Image_Downloader
{
    partial class SettingsWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbAuto = new System.Windows.Forms.RadioButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpColumnDetection = new System.Windows.Forms.GroupBox();
            this.rdbFirstSelected = new System.Windows.Forms.RadioButton();
            this.grpAuth = new System.Windows.Forms.GroupBox();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.chkRequireLogin = new System.Windows.Forms.CheckBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.grpStartingRow = new System.Windows.Forms.GroupBox();
            this.rdbFirstSelectedRow = new System.Windows.Forms.RadioButton();
            this.rdbRow2 = new System.Windows.Forms.RadioButton();
            this.lblImageColumWidth = new System.Windows.Forms.Label();
            this.numericUpDownImageColumnWidth = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.grpColumnDetection.SuspendLayout();
            this.grpAuth.SuspendLayout();
            this.grpStartingRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImageColumnWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbAuto
            // 
            this.rdbAuto.AutoSize = true;
            this.rdbAuto.Checked = true;
            this.rdbAuto.Location = new System.Drawing.Point(12, 19);
            this.rdbAuto.Name = "rdbAuto";
            this.rdbAuto.Size = new System.Drawing.Size(72, 17);
            this.rdbAuto.TabIndex = 1;
            this.rdbAuto.TabStop = true;
            this.rdbAuto.Text = "Automatic";
            this.rdbAuto.UseVisualStyleBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(9, 57);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(11, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 271);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(222, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpColumnDetection
            // 
            this.grpColumnDetection.Controls.Add(this.rdbAuto);
            this.grpColumnDetection.Controls.Add(this.rdbFirstSelected);
            this.grpColumnDetection.Location = new System.Drawing.Point(12, 12);
            this.grpColumnDetection.Name = "grpColumnDetection";
            this.grpColumnDetection.Size = new System.Drawing.Size(125, 70);
            this.grpColumnDetection.TabIndex = 10;
            this.grpColumnDetection.TabStop = false;
            this.grpColumnDetection.Text = "Column Detection";
            // 
            // rdbFirstSelected
            // 
            this.rdbFirstSelected.AutoSize = true;
            this.rdbFirstSelected.Checked = global::Image_Downloader.Properties.Settings.Default.ColumnDetectionManual;
            this.rdbFirstSelected.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Image_Downloader.Properties.Settings.Default, "ColumnDetectionManual", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdbFirstSelected.Location = new System.Drawing.Point(12, 43);
            this.rdbFirstSelected.Name = "rdbFirstSelected";
            this.rdbFirstSelected.Size = new System.Drawing.Size(106, 17);
            this.rdbFirstSelected.TabIndex = 2;
            this.rdbFirstSelected.Text = "First selected cell";
            this.rdbFirstSelected.UseVisualStyleBackColor = true;
            // 
            // grpAuth
            // 
            this.grpAuth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpAuth.Controls.Add(this.tboxUsername);
            this.grpAuth.Controls.Add(this.chkRequireLogin);
            this.grpAuth.Controls.Add(this.lblUsername);
            this.grpAuth.Controls.Add(this.lblPassword);
            this.grpAuth.Controls.Add(this.tboxPassword);
            this.grpAuth.Location = new System.Drawing.Point(12, 141);
            this.grpAuth.Name = "grpAuth";
            this.grpAuth.Size = new System.Drawing.Size(295, 124);
            this.grpAuth.TabIndex = 11;
            this.grpAuth.TabStop = false;
            this.grpAuth.Text = "Authentication";
            // 
            // tboxUsername
            // 
            this.tboxUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Image_Downloader.Properties.Settings.Default, "AuthUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tboxUsername.Location = new System.Drawing.Point(73, 54);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(100, 20);
            this.tboxUsername.TabIndex = 6;
            this.tboxUsername.Text = global::Image_Downloader.Properties.Settings.Default.AuthUsername;
            // 
            // chkRequireLogin
            // 
            this.chkRequireLogin.AutoSize = true;
            this.chkRequireLogin.Checked = global::Image_Downloader.Properties.Settings.Default.AuthRequired;
            this.chkRequireLogin.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Image_Downloader.Properties.Settings.Default, "AuthRequired", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkRequireLogin.Location = new System.Drawing.Point(12, 19);
            this.chkRequireLogin.Name = "chkRequireLogin";
            this.chkRequireLogin.Size = new System.Drawing.Size(113, 17);
            this.chkRequireLogin.TabIndex = 3;
            this.chkRequireLogin.Text = "URLs require login";
            this.chkRequireLogin.UseVisualStyleBackColor = true;
            this.chkRequireLogin.CheckedChanged += new System.EventHandler(this.chkRequireLogin_CheckedChanged);
            // 
            // tboxPassword
            // 
            this.tboxPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Image_Downloader.Properties.Settings.Default, "AuthPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tboxPassword.Location = new System.Drawing.Point(73, 82);
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.Size = new System.Drawing.Size(100, 20);
            this.tboxPassword.TabIndex = 7;
            this.tboxPassword.Text = global::Image_Downloader.Properties.Settings.Default.AuthPassword;
            this.tboxPassword.UseSystemPasswordChar = true;
            // 
            // grpStartingRow
            // 
            this.grpStartingRow.Controls.Add(this.rdbFirstSelectedRow);
            this.grpStartingRow.Controls.Add(this.rdbRow2);
            this.grpStartingRow.Location = new System.Drawing.Point(144, 13);
            this.grpStartingRow.Name = "grpStartingRow";
            this.grpStartingRow.Size = new System.Drawing.Size(163, 69);
            this.grpStartingRow.TabIndex = 12;
            this.grpStartingRow.TabStop = false;
            this.grpStartingRow.Text = "Starting Row";
            // 
            // rdbFirstSelectedRow
            // 
            this.rdbFirstSelectedRow.AutoSize = true;
            this.rdbFirstSelectedRow.Checked = global::Image_Downloader.Properties.Settings.Default.RowDetectionManual;
            this.rdbFirstSelectedRow.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Image_Downloader.Properties.Settings.Default, "RowDetectionManual", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdbFirstSelectedRow.Location = new System.Drawing.Point(6, 42);
            this.rdbFirstSelectedRow.Name = "rdbFirstSelectedRow";
            this.rdbFirstSelectedRow.Size = new System.Drawing.Size(106, 17);
            this.rdbFirstSelectedRow.TabIndex = 1;
            this.rdbFirstSelectedRow.Text = "First selected cell";
            this.rdbFirstSelectedRow.UseVisualStyleBackColor = true;
            // 
            // rdbRow2
            // 
            this.rdbRow2.AutoSize = true;
            this.rdbRow2.Checked = true;
            this.rdbRow2.Location = new System.Drawing.Point(6, 18);
            this.rdbRow2.Name = "rdbRow2";
            this.rdbRow2.Size = new System.Drawing.Size(138, 17);
            this.rdbRow2.TabIndex = 0;
            this.rdbRow2.TabStop = true;
            this.rdbRow2.Text = "Row 2 (First row is titles)";
            this.rdbRow2.UseVisualStyleBackColor = true;
            // 
            // lblImageColumWidth
            // 
            this.lblImageColumWidth.AutoSize = true;
            this.lblImageColumWidth.Location = new System.Drawing.Point(12, 96);
            this.lblImageColumWidth.Name = "lblImageColumWidth";
            this.lblImageColumWidth.Size = new System.Drawing.Size(113, 13);
            this.lblImageColumWidth.TabIndex = 13;
            this.lblImageColumWidth.Text = "Images Column Width:";
            // 
            // numericUpDownImageColumnWidth
            // 
            this.numericUpDownImageColumnWidth.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Image_Downloader.Properties.Settings.Default, "ImagesColumnWidth", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownImageColumnWidth.Location = new System.Drawing.Point(144, 94);
            this.numericUpDownImageColumnWidth.Name = "numericUpDownImageColumnWidth";
            this.numericUpDownImageColumnWidth.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownImageColumnWidth.TabIndex = 14;
            this.numericUpDownImageColumnWidth.Value = global::Image_Downloader.Properties.Settings.Default.ImagesColumnWidth;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(224, 96);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(64, 13);
            this.lblMax.TabIndex = 15;
            this.lblMax.Text = "(Max is 100)";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 313);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.numericUpDownImageColumnWidth);
            this.Controls.Add(this.lblImageColumWidth);
            this.Controls.Add(this.grpStartingRow);
            this.Controls.Add(this.grpAuth);
            this.Controls.Add(this.grpColumnDetection);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "SettingsWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.grpColumnDetection.ResumeLayout(false);
            this.grpColumnDetection.PerformLayout();
            this.grpAuth.ResumeLayout(false);
            this.grpAuth.PerformLayout();
            this.grpStartingRow.ResumeLayout(false);
            this.grpStartingRow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImageColumnWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbAuto;
        private System.Windows.Forms.RadioButton rdbFirstSelected;
        private System.Windows.Forms.CheckBox chkRequireLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tboxUsername;
        private System.Windows.Forms.TextBox tboxPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpColumnDetection;
        private System.Windows.Forms.GroupBox grpAuth;
        private System.Windows.Forms.GroupBox grpStartingRow;
        private System.Windows.Forms.RadioButton rdbFirstSelectedRow;
        private System.Windows.Forms.RadioButton rdbRow2;
        private System.Windows.Forms.Label lblImageColumWidth;
        private System.Windows.Forms.NumericUpDown numericUpDownImageColumnWidth;
        private System.Windows.Forms.Label lblMax;
    }
}