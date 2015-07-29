using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace CleanLoad
{
    public class LinkgrabberPresenter
    {
        private readonly ILinkgrabberLayer linkView;

        public string dlcPath;

        public LinkgrabberPresenter(ILinkgrabberLayer linkView)
        {
            this.linkView = linkView;
            Initialize();
        }

        private void Initialize()
        {
            linkView.LINKGetLinksFromDLC += GetLinksFromDLC;
            linkView.LINKGetLinksFromRaw += GetLinksFromRaw;
            linkView.LINKBrowseDLC += BrowseDLC;
            linkView.LINKDeleteCombinedLinks += DeleteCombinedLinks;
        }


        private void GetLinksFromDLC(object sender, ProxyEventArgs e)
        {
            DLC dlc = new DLC(linkView.DlcPath, e.WebProxy);
            List<string> tempList = new List<string>(linkView.CombinedLinks);
            tempList.AddRange(dlc.decryptContainer());
            linkView.CombinedLinks = tempList;
        }
        private void GetLinksFromRaw(object sender, EventArgs e)
        {
            //VALIDATE: Validate Links, check double entries (Also for links from DLC)
            List<string> tempList = new List<string>(linkView.CombinedLinks);
            tempList.AddRange(linkView.RawLinks);
            linkView.CombinedLinks = tempList;
        }

        private void BrowseDLC(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "dlc files (*.dlc)|*.dlc";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                linkView.DlcPath = openFileDialog1.FileName;
                dlcPath = openFileDialog1.FileName;
            }
        }

        private void DeleteCombinedLinks(object sender, EventArgs e)
        {
            linkView.CombinedLinks = new List<string>();
        }
    }
}
