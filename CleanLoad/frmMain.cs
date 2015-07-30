using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace CleanLoad
{
    public partial class frmMain : Form, ISettingsLayer, ILinkgrabberLayer, IDownloaderLayer
    {
        private SettingsPresenter setPresenter;
        private LinkgrabberPresenter linkPresenter;
        private DownloaderPresenter dlPresenter;

        #region Setting Properies
        public string ProxyAddress
        {
            get { return tbSET_ProxyAddress.Text; }
            set { tbSET_ProxyAddress.Text = value; }
        }

        public string ProxyUsername
        {
            get { return tbSET_ProxyUser.Text; }
            set { tbSET_ProxyUser.Text = value; }
        }

        public string ProxyPassword
        {
            get { return tbSET_ProxyPassword.Text; }
            set { tbSET_ProxyPassword.Text = value; }
        }

        public bool IsProxyActive
        {
            get { return cbSET_UseProxy.Checked; }
            set { cbSET_UseProxy.Checked = value; }
        }

        public string UploadedUsername
        {
            get { return tbSET_ULUser.Text; }
            set { tbSET_ULUser.Text = value; }
        }

        public string UploadedPassword
        {
            get { return tbSET_ULPassword.Text; }
            set { tbSET_ULPassword.Text = value; }
        }

        public string DownloadPath
        {
            get { return tbSET_DLPath.Text; }
            set { tbSET_DLPath.Text = value; }
        }


        public event EventHandler<EventArgs> SETSaveSettings;
        public event EventHandler<EventArgs> SETBrowseDLPath;
        #endregion

        #region Linkgrabber Properties

        public string[] RawLinks
        {
            get { return tbLG_RawLinks.Lines; }
            set { tbSET_ProxyAddress.Lines = value; }
        }

        public List<string> CombinedLinks
        {
            get
            {
                List<string> tempList = new List<string>();
                foreach (string s in lbLG_AddedLinks.Items)
                    tempList.Add(s);
                return tempList;
            }
            set
            {
                lbLG_AddedLinks.Items.Clear();
                lbLG_AddedLinks.Items.AddRange(value.ToArray<string>());
            }
        }

        public string DlcPath
        {
            get { return tbLG_DLCFilePath.Text; }
            set { tbLG_DLCFilePath.Text = value; }
        }

        public event EventHandler<ProxyEventArgs> LINKGetLinksFromDLC;
        public event EventHandler<EventArgs> LINKGetLinksFromRaw;
        public event EventHandler<EventArgs> LINKBrowseDLC;
        public event EventHandler<EventArgs> LINKDeleteCombinedLinks;

        #endregion

        #region Downloader Properties
        public List<string[]> DLListView
        {
            get 
            {
                List<string[]> tempList = new List<string[]>();
                foreach (ListViewItem item in listViewDL.Items)
                {
                    string[] tempStringArray = new string[2];
                    tempStringArray[0] = item.Text;
                    tempStringArray[1] = item.SubItems[1].Text;
                    tempList.Add(tempStringArray);
                }
                return tempList;
            }
            set 
            {
                listViewDL.Items.Clear();
                foreach (string[] item in value)
                    listViewDL.Items.Add(item[0]).SubItems.Add(item[1]);
            }
        }

        public string DLButtonStartStop
        {
            get { return btnDL_StartStop.Text; }
            set { btnDL_StartStop.Text = value; }
        }

        public string GlobalStatus
        {
            get { return lblGlobalState.Text; }
            set { lblGlobalState.Text = value; }
        }


        public event EventHandler<DownloadEventArgs> DLStartStop;
        public event EventHandler<LinksEventArgs> DLGetDataFromLINK;
        #endregion



        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            setPresenter = new SettingsPresenter(this);
            linkPresenter = new LinkgrabberPresenter(this);
            dlPresenter = new DownloaderPresenter(this);


            listViewDL.View = View.Details;
            listViewDL.FullRowSelect = true;
            listViewDL.Columns.Add("File", -2, HorizontalAlignment.Left);
            listViewDL.Columns.Add("Status", -2, HorizontalAlignment.Left);
        }

        public void DLViewUpdatePercentage(DLFile dlFile, int percentage)
        {
            ListViewItem lvItem = listViewDL.FindItemWithText(dlFile.DlURL);
            if (lvItem != null)
                listViewDL.Items[lvItem.Index].SubItems[1].Text = percentage.ToString() + " %";

        }






        private void btnSET_Save_Click(object sender, EventArgs e)
        {
            //VALIDATE: Validate input
            if (SETSaveSettings != null)
            {
                SETSaveSettings(this, EventArgs.Empty);
                MessageBox.Show("Settings were saved");
            }
        }

        private void cbSET_UseProxy_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSET_UseProxy.Checked)
            {
                tbSET_ProxyAddress.Enabled = true;
                tbSET_ProxyPassword.Enabled = true;
                tbSET_ProxyUser.Enabled = true;
            }
            else
            {
                tbSET_ProxyAddress.Enabled = false;
                tbSET_ProxyPassword.Enabled = false;
                tbSET_ProxyUser.Enabled = false;
            }
        }

        private void btnSET_BrowseDLPath_Click(object sender, EventArgs e)
        {
            if (SETBrowseDLPath != null)
            {
                SETBrowseDLPath(this, EventArgs.Empty);
            }
        }

        private void btnLG_BrowseDLC_Click(object sender, EventArgs e)
        {
            if (LINKBrowseDLC != null)
            {
                LINKBrowseDLC(this, EventArgs.Empty);
            }
        }

        private void btnLG_AddRawToList_Click(object sender, EventArgs e)
        {
            if (LINKGetLinksFromRaw != null)
                LINKGetLinksFromRaw(this, EventArgs.Empty);
        }

        private void btnLG_AddDLCToList_Click(object sender, EventArgs e)
        {
            if (LINKGetLinksFromDLC != null && !String.IsNullOrEmpty(tbLG_DLCFilePath.Text))
                LINKGetLinksFromDLC(this, new ProxyEventArgs(setPresenter.currentProxy));
        }

        private void btnLG_SubmitToDL_Click(object sender, EventArgs e)
        {
            if (DLGetDataFromLINK != null)
                DLGetDataFromLINK(this, new LinksEventArgs(CombinedLinks));
            tabControl1.SelectedTab = tapPageDownload;
            if (LINKDeleteCombinedLinks != null)
                LINKDeleteCombinedLinks(this, EventArgs.Empty);
            foreach (ColumnHeader column in listViewDL.Columns)
                column.Width = -2;
        }

        private void btnDL_StartStop_Click(object sender, EventArgs e)
        {
            if (DLStartStop != null)
                DLStartStop(this, new DownloadEventArgs(setPresenter.currentProxy, setPresenter.ulAccount, setPresenter.downloadPath));
        }
    }
}
