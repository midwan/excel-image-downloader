﻿namespace Image_Downloader
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
            this.rdbFirstSelected = new System.Windows.Forms.RadioButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tboxUsername = new System.Windows.Forms.TextBox();
            this.tboxPassword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpColumnDetection = new System.Windows.Forms.GroupBox();
            this.grpAuth = new System.Windows.Forms.GroupBox();
            this.chkRequireLogin = new System.Windows.Forms.CheckBox();
            this.grpColumnDetection.SuspendLayout();
            this.grpAuth.SuspendLayout();
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
            // tboxUsername
            // 
            this.tboxUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Image_Downloader.Properties.Settings.Default, "AuthUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tboxUsername.Location = new System.Drawing.Point(73, 54);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.Size = new System.Drawing.Size(100, 20);
            this.tboxUsername.TabIndex = 6;
            this.tboxUsername.Text = global::Image_Downloader.Properties.Settings.Default.AuthUsername;
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
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(12, 243);
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
            this.btnCancel.Location = new System.Drawing.Point(132, 243);
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
            this.grpColumnDetection.Size = new System.Drawing.Size(200, 70);
            this.grpColumnDetection.TabIndex = 10;
            this.grpColumnDetection.TabStop = false;
            this.grpColumnDetection.Text = "Column Detection";
            // 
            // grpAuth
            // 
            this.grpAuth.Controls.Add(this.tboxUsername);
            this.grpAuth.Controls.Add(this.chkRequireLogin);
            this.grpAuth.Controls.Add(this.lblUsername);
            this.grpAuth.Controls.Add(this.lblPassword);
            this.grpAuth.Controls.Add(this.tboxPassword);
            this.grpAuth.Location = new System.Drawing.Point(12, 88);
            this.grpAuth.Name = "grpAuth";
            this.grpAuth.Size = new System.Drawing.Size(200, 124);
            this.grpAuth.TabIndex = 11;
            this.grpAuth.TabStop = false;
            this.grpAuth.Text = "Authentication";
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
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 285);
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
            this.ResumeLayout(false);

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
    }
}