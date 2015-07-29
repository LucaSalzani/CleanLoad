using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanLoad
{
    enum StatusEnum
    {
        Ready,
        Downloading,
        Error,
        Done
    }



    public class DownloaderPresenter
    {
        private readonly IDownloaderLayer dlView;
        private bool isStarted;

        public DownloaderPresenter(IDownloaderLayer dlView)
        {
            this.dlView = dlView;
            Initialize();
        }

        private void Initialize()
        {
            dlView.DLStartStop += DLStartStop;
            dlView.DLGetDataFromLINK += DLGetDataFromLINK;
            isStarted = false;
        }

        private void DLStartStop(object sender, DownloadEventArgs e)
        {
            //VALIDATE: Input for DLStartStop


            //TODO: Implement DLStartStop
        }

        private void DLGetDataFromLINK(object sender, LinksEventArgs e)
        {
            List<string[]> tempList = new List<string[]>();

            foreach (string item in e.ListDL)
            {
                string[] tempStringArray = new string[2];
                tempStringArray[0] = item;
                tempStringArray[1] = StatusEnum.Ready.ToString();
                tempList.Add(tempStringArray);
            }

            List<string[]> tempAddingList = new List<string[]>();
            tempAddingList = dlView.DLListView;
            tempAddingList.AddRange(tempList);
            dlView.DLListView = tempAddingList;
        }
    }
}
