namespace CleanLoad
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tapPageDownload = new System.Windows.Forms.TabPage();
            this.btnDL_StartStop = new System.Windows.Forms.Button();
            this.listViewDL = new System.Windows.Forms.ListView();
            this.tapPageLinkgrabber = new System.Windows.Forms.TabPage();
            this.btnLG_SubmitToDL = new System.Windows.Forms.Button();
            this.lbLG_AddedLinks = new System.Windows.Forms.ListBox();
            this.gbLG_RawLinks = new System.Windows.Forms.GroupBox();
            this.lblLG_RawInfo = new System.Windows.Forms.Label();
            this.btnLG_AddRawToList = new System.Windows.Forms.Button();
            this.tbLG_RawLinks = new System.Windows.Forms.TextBox();
            this.gbLG_DLC = new System.Windows.Forms.GroupBox();
            this.btnLG_AddDLCToList = new System.Windows.Forms.Button();
            this.btnLG_BrowseDLC = new System.Windows.Forms.Button();
            this.tbLG_DLCFilePath = new System.Windows.Forms.TextBox();
            this.tapPageSettings = new System.Windows.Forms.TabPage();
            this.btnSET_BrowseDLPath = new System.Windows.Forms.Button();
            this.btnSET_Save = new System.Windows.Forms.Button();
            this.gbSET_ULAccount = new System.Windows.Forms.GroupBox();
            this.tbSET_ULPassword = new System.Windows.Forms.TextBox();
            this.lblSET_PWUL = new System.Windows.Forms.Label();
            this.tbSET_ULUser = new System.Windows.Forms.TextBox();
            this.lblSET_UserUL = new System.Windows.Forms.Label();
            this.tbSET_DLPath = new System.Windows.Forms.TextBox();
            this.lblSET_DLPath = new System.Windows.Forms.Label();
            this.gbSET_Proxy = new System.Windows.Forms.GroupBox();
            this.tbSET_ProxyPassword = new System.Windows.Forms.TextBox();
            this.lblSET_Password = new System.Windows.Forms.Label();
            this.tbSET_ProxyUser = new System.Windows.Forms.TextBox();
            this.lblSET_User = new System.Windows.Forms.Label();
            this.tbSET_ProxyAddress = new System.Windows.Forms.TextBox();
            this.lblSET_ProxyAddress = new System.Windows.Forms.Label();
            this.cbSET_UseProxy = new System.Windows.Forms.CheckBox();
            this.lblGlobalState = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tapPageDownload.SuspendLayout();
            this.tapPageLinkgrabber.SuspendLayout();
            this.gbLG_RawLinks.SuspendLayout();
            this.gbLG_DLC.SuspendLayout();
            this.tapPageSettings.SuspendLayout();
            this.gbSET_ULAccount.SuspendLayout();
            this.gbSET_Proxy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tapPageDownload);
            this.tabControl1.Controls.Add(this.tapPageLinkgrabber);
            this.tabControl1.Controls.Add(this.tapPageSettings);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 515);
            this.tabControl1.TabIndex = 0;
            // 
            // tapPageDownload
            // 
            this.tapPageDownload.Controls.Add(this.btnDL_StartStop);
            this.tapPageDownload.Controls.Add(this.listViewDL);
            this.tapPageDownload.Location = new System.Drawing.Point(4, 22);
            this.tapPageDownload.Name = "tapPageDownload";
            this.tapPageDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tapPageDownload.Size = new System.Drawing.Size(776, 489);
            this.tapPageDownload.TabIndex = 1;
            this.tapPageDownload.Text = "Downloader";
            this.tapPageDownload.UseVisualStyleBackColor = true;
            // 
            // btnDL_StartStop
            // 
            this.btnDL_StartStop.Location = new System.Drawing.Point(6, 280);
            this.btnDL_StartStop.Name = "btnDL_StartStop";
            this.btnDL_StartStop.Size = new System.Drawing.Size(75, 23);
            this.btnDL_StartStop.TabIndex = 1;
            this.btnDL_StartStop.Text = "Start";
            this.btnDL_StartStop.UseVisualStyleBackColor = true;
            this.btnDL_StartStop.Click += new System.EventHandler(this.btnDL_StartStop_Click);
            // 
            // listViewDL
            // 
            this.listViewDL.FullRowSelect = true;
            this.listViewDL.GridLines = true;
            this.listViewDL.Location = new System.Drawing.Point(6, 6);
            this.listViewDL.Name = "listViewDL";
            this.listViewDL.Size = new System.Drawing.Size(764, 268);
            this.listViewDL.TabIndex = 0;
            this.listViewDL.UseCompatibleStateImageBehavior = false;
            this.listViewDL.View = System.Windows.Forms.View.Details;
            // 
            // tapPageLinkgrabber
            // 
            this.tapPageLinkgrabber.Controls.Add(this.btnLG_SubmitToDL);
            this.tapPageLinkgrabber.Controls.Add(this.lbLG_AddedLinks);
            this.tapPageLinkgrabber.Controls.Add(this.gbLG_RawLinks);
            this.tapPageLinkgrabber.Controls.Add(this.gbLG_DLC);
            this.tapPageLinkgrabber.Location = new System.Drawing.Point(4, 22);
            this.tapPageLinkgrabber.Name = "tapPageLinkgrabber";
            this.tapPageLinkgrabber.Padding = new System.Windows.Forms.Padding(3);
            this.tapPageLinkgrabber.Size = new System.Drawing.Size(776, 489);
            this.tapPageLinkgrabber.TabIndex = 0;
            this.tapPageLinkgrabber.Text = "Link grabber";
            this.tapPageLinkgrabber.UseVisualStyleBackColor = true;
            // 
            // btnLG_SubmitToDL
            // 
            this.btnLG_SubmitToDL.Location = new System.Drawing.Point(12, 352);
            this.btnLG_SubmitToDL.Name = "btnLG_SubmitToDL";
            this.btnLG_SubmitToDL.Size = new System.Drawing.Size(149, 23);
            this.btnLG_SubmitToDL.TabIndex = 3;
            this.btnLG_SubmitToDL.Text = "Submit to Downloader";
            this.btnLG_SubmitToDL.UseVisualStyleBackColor = true;
            this.btnLG_SubmitToDL.Click += new System.EventHandler(this.btnLG_SubmitToDL_Click);
            // 
            // lbLG_AddedLinks
            // 
            this.lbLG_AddedLinks.FormattingEnabled = true;
            this.lbLG_AddedLinks.Location = new System.Drawing.Point(12, 238);
            this.lbLG_AddedLinks.Name = "lbLG_AddedLinks";
            this.lbLG_AddedLinks.Size = new System.Drawing.Size(560, 108);
            this.lbLG_AddedLinks.TabIndex = 2;
            // 
            // gbLG_RawLinks
            // 
            this.gbLG_RawLinks.Controls.Add(this.lblLG_RawInfo);
            this.gbLG_RawLinks.Controls.Add(this.btnLG_AddRawToList);
            this.gbLG_RawLinks.Controls.Add(this.tbLG_RawLinks);
            this.gbLG_RawLinks.Location = new System.Drawing.Point(292, 6);
            this.gbLG_RawLinks.Name = "gbLG_RawLinks";
            this.gbLG_RawLinks.Size = new System.Drawing.Size(280, 180);
            this.gbLG_RawLinks.TabIndex = 1;
            this.gbLG_RawLinks.TabStop = false;
            this.gbLG_RawLinks.Text = "Raw links";
            // 
            // lblLG_RawInfo
            // 
            this.lblLG_RawInfo.AutoSize = true;
            this.lblLG_RawInfo.Location = new System.Drawing.Point(191, 156);
            this.lblLG_RawInfo.Name = "lblLG_RawInfo";
            this.lblLG_RawInfo.Size = new System.Drawing.Size(83, 13);
            this.lblLG_RawInfo.TabIndex = 2;
            this.lblLG_RawInfo.Text = "One link per line";
            // 
            // btnLG_AddRawToList
            // 
            this.btnLG_AddRawToList.Location = new System.Drawing.Point(6, 151);
            this.btnLG_AddRawToList.Name = "btnLG_AddRawToList";
            this.btnLG_AddRawToList.Size = new System.Drawing.Size(91, 23);
            this.btnLG_AddRawToList.TabIndex = 1;
            this.btnLG_AddRawToList.Text = "Add to list";
            this.btnLG_AddRawToList.UseVisualStyleBackColor = true;
            this.btnLG_AddRawToList.Click += new System.EventHandler(this.btnLG_AddRawToList_Click);
            // 
            // tbLG_RawLinks
            // 
            this.tbLG_RawLinks.Location = new System.Drawing.Point(6, 19);
            this.tbLG_RawLinks.Multiline = true;
            this.tbLG_RawLinks.Name = "tbLG_RawLinks";
            this.tbLG_RawLinks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLG_RawLinks.Size = new System.Drawing.Size(268, 126);
            this.tbLG_RawLinks.TabIndex = 0;
            // 
            // gbLG_DLC
            // 
            this.gbLG_DLC.Controls.Add(this.btnLG_AddDLCToList);
            this.gbLG_DLC.Controls.Add(this.btnLG_BrowseDLC);
            this.gbLG_DLC.Controls.Add(this.tbLG_DLCFilePath);
            this.gbLG_DLC.Location = new System.Drawing.Point(6, 6);
            this.gbLG_DLC.Name = "gbLG_DLC";
            this.gbLG_DLC.Size = new System.Drawing.Size(280, 180);
            this.gbLG_DLC.TabIndex = 1;
            this.gbLG_DLC.TabStop = false;
            this.gbLG_DLC.Text = "DLC";
            // 
            // btnLG_AddDLCToList
            // 
            this.btnLG_AddDLCToList.Location = new System.Drawing.Point(6, 151);
            this.btnLG_AddDLCToList.Name = "btnLG_AddDLCToList";
            this.btnLG_AddDLCToList.Size = new System.Drawing.Size(91, 23);
            this.btnLG_AddDLCToList.TabIndex = 2;
            this.btnLG_AddDLCToList.Text = "Add to list";
            this.btnLG_AddDLCToList.UseVisualStyleBackColor = true;
            this.btnLG_AddDLCToList.Click += new System.EventHandler(this.btnLG_AddDLCToList_Click);
            // 
            // btnLG_BrowseDLC
            // 
            this.btnLG_BrowseDLC.Location = new System.Drawing.Point(183, 17);
            this.btnLG_BrowseDLC.Name = "btnLG_BrowseDLC";
            this.btnLG_BrowseDLC.Size = new System.Drawing.Size(91, 23);
            this.btnLG_BrowseDLC.TabIndex = 1;
            this.btnLG_BrowseDLC.Text = "Browse";
            this.btnLG_BrowseDLC.UseVisualStyleBackColor = true;
            this.btnLG_BrowseDLC.Click += new System.EventHandler(this.btnLG_BrowseDLC_Click);
            // 
            // tbLG_DLCFilePath
            // 
            this.tbLG_DLCFilePath.Location = new System.Drawing.Point(6, 19);
            this.tbLG_DLCFilePath.Name = "tbLG_DLCFilePath";
            this.tbLG_DLCFilePath.Size = new System.Drawing.Size(171, 20);
            this.tbLG_DLCFilePath.TabIndex = 0;
            // 
            // tapPageSettings
            // 
            this.tapPageSettings.Controls.Add(this.btnSET_BrowseDLPath);
            this.tapPageSettings.Controls.Add(this.btnSET_Save);
            this.tapPageSettings.Controls.Add(this.gbSET_ULAccount);
            this.tapPageSettings.Controls.Add(this.tbSET_DLPath);
            this.tapPageSettings.Controls.Add(this.lblSET_DLPath);
            this.tapPageSettings.Controls.Add(this.gbSET_Proxy);
            this.tapPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tapPageSettings.Name = "tapPageSettings";
            this.tapPageSettings.Size = new System.Drawing.Size(776, 489);
            this.tapPageSettings.TabIndex = 2;
            this.tapPageSettings.Text = "Settings";
            this.tapPageSettings.UseVisualStyleBackColor = true;
            // 
            // btnSET_BrowseDLPath
            // 
            this.btnSET_BrowseDLPath.Location = new System.Drawing.Point(249, 177);
            this.btnSET_BrowseDLPath.Name = "btnSET_BrowseDLPath";
            this.btnSET_BrowseDLPath.Size = new System.Drawing.Size(75, 23);
            this.btnSET_BrowseDLPath.TabIndex = 2;
            this.btnSET_BrowseDLPath.Text = "Browse";
            this.btnSET_BrowseDLPath.UseVisualStyleBackColor = true;
            this.btnSET_BrowseDLPath.Click += new System.EventHandler(this.btnSET_BrowseDLPath_Click);
            // 
            // btnSET_Save
            // 
            this.btnSET_Save.Location = new System.Drawing.Point(3, 299);
            this.btnSET_Save.Name = "btnSET_Save";
            this.btnSET_Save.Size = new System.Drawing.Size(75, 23);
            this.btnSET_Save.TabIndex = 2;
            this.btnSET_Save.Text = "Save";
            this.btnSET_Save.UseVisualStyleBackColor = true;
            this.btnSET_Save.Click += new System.EventHandler(this.btnSET_Save_Click);
            // 
            // gbSET_ULAccount
            // 
            this.gbSET_ULAccount.Controls.Add(this.tbSET_ULPassword);
            this.gbSET_ULAccount.Controls.Add(this.lblSET_PWUL);
            this.gbSET_ULAccount.Controls.Add(this.tbSET_ULUser);
            this.gbSET_ULAccount.Controls.Add(this.lblSET_UserUL);
            this.gbSET_ULAccount.Location = new System.Drawing.Point(255, 12);
            this.gbSET_ULAccount.Name = "gbSET_ULAccount";
            this.gbSET_ULAccount.Size = new System.Drawing.Size(246, 138);
            this.gbSET_ULAccount.TabIndex = 1;
            this.gbSET_ULAccount.TabStop = false;
            this.gbSET_ULAccount.Text = "Uploaded Account";
            // 
            // tbSET_ULPassword
            // 
            this.tbSET_ULPassword.Location = new System.Drawing.Point(65, 45);
            this.tbSET_ULPassword.Name = "tbSET_ULPassword";
            this.tbSET_ULPassword.PasswordChar = '●';
            this.tbSET_ULPassword.Size = new System.Drawing.Size(175, 20);
            this.tbSET_ULPassword.TabIndex = 2;
            // 
            // lblSET_PWUL
            // 
            this.lblSET_PWUL.AutoSize = true;
            this.lblSET_PWUL.Location = new System.Drawing.Point(6, 48);
            this.lblSET_PWUL.Name = "lblSET_PWUL";
            this.lblSET_PWUL.Size = new System.Drawing.Size(53, 13);
            this.lblSET_PWUL.TabIndex = 1;
            this.lblSET_PWUL.Text = "Password";
            // 
            // tbSET_ULUser
            // 
            this.tbSET_ULUser.Location = new System.Drawing.Point(65, 19);
            this.tbSET_ULUser.Name = "tbSET_ULUser";
            this.tbSET_ULUser.Size = new System.Drawing.Size(175, 20);
            this.tbSET_ULUser.TabIndex = 2;
            // 
            // lblSET_UserUL
            // 
            this.lblSET_UserUL.AutoSize = true;
            this.lblSET_UserUL.Location = new System.Drawing.Point(6, 22);
            this.lblSET_UserUL.Name = "lblSET_UserUL";
            this.lblSET_UserUL.Size = new System.Drawing.Size(29, 13);
            this.lblSET_UserUL.TabIndex = 1;
            this.lblSET_UserUL.Text = "User";
            // 
            // tbSET_DLPath
            // 
            this.tbSET_DLPath.Location = new System.Drawing.Point(68, 179);
            this.tbSET_DLPath.Name = "tbSET_DLPath";
            this.tbSET_DLPath.Size = new System.Drawing.Size(175, 20);
            this.tbSET_DLPath.TabIndex = 2;
            // 
            // lblSET_DLPath
            // 
            this.lblSET_DLPath.AutoSize = true;
            this.lblSET_DLPath.Location = new System.Drawing.Point(9, 182);
            this.lblSET_DLPath.Name = "lblSET_DLPath";
            this.lblSET_DLPath.Size = new System.Drawing.Size(46, 13);
            this.lblSET_DLPath.TabIndex = 1;
            this.lblSET_DLPath.Text = "DL-Path";
            // 
            // gbSET_Proxy
            // 
            this.gbSET_Proxy.Controls.Add(this.tbSET_ProxyPassword);
            this.gbSET_Proxy.Controls.Add(this.lblSET_Password);
            this.gbSET_Proxy.Controls.Add(this.tbSET_ProxyUser);
            this.gbSET_Proxy.Controls.Add(this.lblSET_User);
            this.gbSET_Proxy.Controls.Add(this.tbSET_ProxyAddress);
            this.gbSET_Proxy.Controls.Add(this.lblSET_ProxyAddress);
            this.gbSET_Proxy.Controls.Add(this.cbSET_UseProxy);
            this.gbSET_Proxy.Location = new System.Drawing.Point(3, 12);
            this.gbSET_Proxy.Name = "gbSET_Proxy";
            this.gbSET_Proxy.Size = new System.Drawing.Size(246, 138);
            this.gbSET_Proxy.TabIndex = 1;
            this.gbSET_Proxy.TabStop = false;
            this.gbSET_Proxy.Text = "Proxy";
            // 
            // tbSET_ProxyPassword
            // 
            this.tbSET_ProxyPassword.Enabled = false;
            this.tbSET_ProxyPassword.Location = new System.Drawing.Point(65, 94);
            this.tbSET_ProxyPassword.Name = "tbSET_ProxyPassword";
            this.tbSET_ProxyPassword.PasswordChar = '●';
            this.tbSET_ProxyPassword.Size = new System.Drawing.Size(175, 20);
            this.tbSET_ProxyPassword.TabIndex = 2;
            // 
            // lblSET_Password
            // 
            this.lblSET_Password.AutoSize = true;
            this.lblSET_Password.Location = new System.Drawing.Point(6, 97);
            this.lblSET_Password.Name = "lblSET_Password";
            this.lblSET_Password.Size = new System.Drawing.Size(53, 13);
            this.lblSET_Password.TabIndex = 1;
            this.lblSET_Password.Text = "Password";
            // 
            // tbSET_ProxyUser
            // 
            this.tbSET_ProxyUser.Enabled = false;
            this.tbSET_ProxyUser.Location = new System.Drawing.Point(65, 68);
            this.tbSET_ProxyUser.Name = "tbSET_ProxyUser";
            this.tbSET_ProxyUser.Size = new System.Drawing.Size(175, 20);
            this.tbSET_ProxyUser.TabIndex = 2;
            // 
            // lblSET_User
            // 
            this.lblSET_User.AutoSize = true;
            this.lblSET_User.Location = new System.Drawing.Point(6, 71);
            this.lblSET_User.Name = "lblSET_User";
            this.lblSET_User.Size = new System.Drawing.Size(29, 13);
            this.lblSET_User.TabIndex = 1;
            this.lblSET_User.Text = "User";
            // 
            // tbSET_ProxyAddress
            // 
            this.tbSET_ProxyAddress.Enabled = false;
            this.tbSET_ProxyAddress.Location = new System.Drawing.Point(65, 42);
            this.tbSET_ProxyAddress.Name = "tbSET_ProxyAddress";
            this.tbSET_ProxyAddress.Size = new System.Drawing.Size(175, 20);
            this.tbSET_ProxyAddress.TabIndex = 2;
            // 
            // lblSET_ProxyAddress
            // 
            this.lblSET_ProxyAddress.AutoSize = true;
            this.lblSET_ProxyAddress.Location = new System.Drawing.Point(6, 45);
            this.lblSET_ProxyAddress.Name = "lblSET_ProxyAddress";
            this.lblSET_ProxyAddress.Size = new System.Drawing.Size(45, 13);
            this.lblSET_ProxyAddress.TabIndex = 1;
            this.lblSET_ProxyAddress.Text = "Address";
            // 
            // cbSET_UseProxy
            // 
            this.cbSET_UseProxy.AutoSize = true;
            this.cbSET_UseProxy.Location = new System.Drawing.Point(6, 19);
            this.cbSET_UseProxy.Name = "cbSET_UseProxy";
            this.cbSET_UseProxy.Size = new System.Drawing.Size(74, 17);
            this.cbSET_UseProxy.TabIndex = 0;
            this.cbSET_UseProxy.Text = "Use Proxy";
            this.cbSET_UseProxy.UseVisualStyleBackColor = true;
            this.cbSET_UseProxy.CheckedChanged += new System.EventHandler(this.cbSET_UseProxy_CheckedChanged);
            // 
            // lblGlobalState
            // 
            this.lblGlobalState.AutoSize = true;
            this.lblGlobalState.Location = new System.Drawing.Point(16, 542);
            this.lblGlobalState.Name = "lblGlobalState";
            this.lblGlobalState.Size = new System.Drawing.Size(0, 13);
            this.lblGlobalState.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 567);
            this.Controls.Add(this.lblGlobalState);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Clean Load";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tapPageDownload.ResumeLayout(false);
            this.tapPageLinkgrabber.ResumeLayout(false);
            this.gbLG_RawLinks.ResumeLayout(false);
            this.gbLG_RawLinks.PerformLayout();
            this.gbLG_DLC.ResumeLayout(false);
            this.gbLG_DLC.PerformLayout();
            this.tapPageSettings.ResumeLayout(false);
            this.tapPageSettings.PerformLayout();
            this.gbSET_ULAccount.ResumeLayout(false);
            this.gbSET_ULAccount.PerformLayout();
            this.gbSET_Proxy.ResumeLayout(false);
            this.gbSET_Proxy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tapPageLinkgrabber;
        private System.Windows.Forms.TabPage tapPageDownload;
        private System.Windows.Forms.TabPage tapPageSettings;
        private System.Windows.Forms.Label lblGlobalState;
        private System.Windows.Forms.GroupBox gbLG_DLC;
        private System.Windows.Forms.TextBox tbLG_DLCFilePath;
        private System.Windows.Forms.GroupBox gbLG_RawLinks;
        private System.Windows.Forms.Button btnLG_AddRawToList;
        private System.Windows.Forms.TextBox tbLG_RawLinks;
        private System.Windows.Forms.Button btnLG_AddDLCToList;
        private System.Windows.Forms.Button btnLG_BrowseDLC;
        private System.Windows.Forms.Label lblLG_RawInfo;
        private System.Windows.Forms.ListBox lbLG_AddedLinks;
        private System.Windows.Forms.Button btnLG_SubmitToDL;
        private System.Windows.Forms.GroupBox gbSET_Proxy;
        private System.Windows.Forms.TextBox tbSET_ProxyPassword;
        private System.Windows.Forms.Label lblSET_Password;
        private System.Windows.Forms.TextBox tbSET_ProxyUser;
        private System.Windows.Forms.Label lblSET_User;
        private System.Windows.Forms.TextBox tbSET_ProxyAddress;
        private System.Windows.Forms.Label lblSET_ProxyAddress;
        private System.Windows.Forms.CheckBox cbSET_UseProxy;
        private System.Windows.Forms.Button btnSET_Save;
        private System.Windows.Forms.GroupBox gbSET_ULAccount;
        private System.Windows.Forms.TextBox tbSET_ULPassword;
        private System.Windows.Forms.Label lblSET_PWUL;
        private System.Windows.Forms.TextBox tbSET_ULUser;
        private System.Windows.Forms.Label lblSET_UserUL;
        private System.Windows.Forms.ListView listViewDL;
        private System.Windows.Forms.Button btnDL_StartStop;
        private System.Windows.Forms.Button btnSET_BrowseDLPath;
        private System.Windows.Forms.TextBox tbSET_DLPath;
        private System.Windows.Forms.Label lblSET_DLPath;
    }
}

