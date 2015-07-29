using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.IO;

namespace CleanLoad
{
    public class SettingsPresenter
    {
        private readonly ISettingsLayer settingsView;
        public WebProxy currentProxy;
        public Proxy myProxy;
        public ULAccount ulAccount;
        public string downloadPath;

        public SettingsPresenter(ISettingsLayer settingsView)
        {
            this.settingsView = settingsView;
            Initialize();
        }

        private void Initialize()
        {
            //Add Events
            settingsView.SETSaveSettings += Save;
            settingsView.SETBrowseDLPath += BrowseDLFolder;

            //Load proxy settings
            settingsView.IsProxyActive = Properties.Settings.Default.ProxyIsActive;
            settingsView.ProxyAddress = Properties.Settings.Default.ProxyAddress;
            settingsView.ProxyUsername = Properties.Settings.Default.ProxyUsername;
            settingsView.ProxyPassword = Properties.Settings.Default.ProxyPassword.Decrypt();

            if (!String.IsNullOrEmpty(settingsView.ProxyAddress))
            {
                myProxy = new Proxy(settingsView.ProxyAddress, settingsView.IsProxyActive, settingsView.ProxyUsername, settingsView.ProxyPassword);
                currentProxy = myProxy.GetProxyToUse();
            }
            else
            {
                myProxy = null;
                currentProxy = null;
            }



            //Load uploaded.net settings
            settingsView.UploadedUsername = Properties.Settings.Default.UploadedUsername;
            settingsView.UploadedPassword = Properties.Settings.Default.UploadedPassword.Decrypt();

            if (!String.IsNullOrEmpty(settingsView.UploadedUsername) && !String.IsNullOrEmpty(settingsView.UploadedPassword))
                ulAccount = new ULAccount(settingsView.UploadedUsername, settingsView.UploadedPassword);
            else
                ulAccount = null;



            //Download path
            settingsView.DownloadPath = Properties.Settings.Default.DownloadPath;
            downloadPath = settingsView.DownloadPath;

        }


        private void Save(object sender, EventArgs e)
        {
            //Proxy settings
            Properties.Settings.Default.ProxyIsActive = settingsView.IsProxyActive;
            Properties.Settings.Default.ProxyAddress = settingsView.ProxyAddress;
            Properties.Settings.Default.ProxyUsername = settingsView.ProxyUsername;
            Properties.Settings.Default.ProxyPassword = settingsView.ProxyPassword.Encrypt();

            if (!String.IsNullOrEmpty(settingsView.ProxyAddress))
                myProxy = new Proxy(settingsView.ProxyAddress, settingsView.IsProxyActive, settingsView.ProxyUsername, settingsView.ProxyPassword);
            else
                myProxy = null;

            //Set WebProxy
            currentProxy = myProxy.GetProxyToUse();


            //Uploaded.net settings
            Properties.Settings.Default.UploadedUsername = settingsView.UploadedUsername;
            Properties.Settings.Default.UploadedPassword = settingsView.UploadedPassword.Encrypt();

            if (!String.IsNullOrEmpty(settingsView.UploadedUsername) && !String.IsNullOrEmpty(settingsView.UploadedPassword))
                ulAccount = new ULAccount(settingsView.UploadedUsername, settingsView.UploadedPassword);
            else
                ulAccount = null;


            //Download path
            Properties.Settings.Default.DownloadPath = settingsView.DownloadPath;
            downloadPath = settingsView.DownloadPath;



            //Save settings
            Properties.Settings.Default.Save();
        }

        private void BrowseDLFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                settingsView.DownloadPath = new DirectoryInfo(folderBrowserDialog1.SelectedPath).FullName;
                downloadPath = settingsView.DownloadPath;
            }
        }
    }
}
