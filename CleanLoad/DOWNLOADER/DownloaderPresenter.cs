using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.ComponentModel;

namespace CleanLoad
{
    public enum StatusEnum
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
        private CookieCollection cookieJar = null;
        BackgroundWorker bw = new BackgroundWorker();



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


            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
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

        private void DLStartStop(object sender, DownloadEventArgs e)
        {
            //VALIDATE: Input for DLStartStop und ListView
            isStarted = !isStarted;

            cookieJar = Logon(e.ULAccount, e.WebProxy);

            
            List<DLFile> listFilesToDL = new List<DLFile>();
            foreach (string[] item in dlView.DLListView)
                if (item[1] == StatusEnum.Ready.ToString())
                    listFilesToDL.Add(new DLFile(item[0], StatusEnum.Ready, e.DLPath, e.WebProxy, cookieJar));
            
            foreach (DLFile file in listFilesToDL)
            {
                file.GetID();
                file.GetDirectDownloadLink();
            }

            if (!bw.IsBusy && listFilesToDL.Count > 0)
            {
                dlView.DLButtonStartStop = "Stop";
                bw.RunWorkerAsync(listFilesToDL);
            }
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            foreach (DLFile file in (List<DLFile>)e.Argument)
            {
                file.Status = StatusEnum.Downloading;
                worker.ReportProgress(-1, file);
                file.DownloadFileFromUL(ref worker);

                if ((worker.CancellationPending == true))
                {
                    e.Cancel = true;
                    break;
                }

                worker.ReportProgress(-1, file);
            }
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState != null)
            {
                DLFile tempFile = (DLFile)e.UserState;

                if (e.ProgressPercentage == -1)
                {
                    List<string[]> tempList = dlView.DLListView;
                    foreach (string[] item in tempList)
                        if (item[0] == tempFile.DlURL)
                            item[1] = tempFile.Status.ToString();

                    dlView.DLListView = tempList;
                }
                else
                {
                    dlView.DLViewUpdatePercentage(tempFile, e.ProgressPercentage);


                    //List<string[]> tempList = dlView.DLListView;
                    //foreach (string[] item in tempList)
                    //    if (item[0] == tempFile.DlURL)
                    //        item[1] = e.ProgressPercentage.ToString() + " %";

                    //dlView.DLListView = tempList;
                }
            }
        }

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dlView.DLButtonStartStop = "Start";
            if ((e.Cancelled == true))
            {
                dlView.GlobalStatus = "Canceled!";
            }

            else if (!(e.Error == null))
            {
                dlView.GlobalStatus = ("Error: " + e.Error.Message);
            }

            else
            {
                dlView.GlobalStatus = "Done!";
            }
        }



        private CookieCollection Logon(ULAccount ulAccount, WebProxy webProxy)
        {
            // this is what we are sending
            string post_data = "id=" + ulAccount.Username + "&pw=" + ulAccount.Password;

            // this is where we will send it
            string uri = "https://uploaded.net/io/login";

            // create a request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.KeepAlive = false;
            request.ProtocolVersion = HttpVersion.Version10;
            request.Method = "POST";

            // turn our request string into a byte stream
            byte[] postBytes = Encoding.ASCII.GetBytes(post_data);

            //Proxy
            if (webProxy != null)
                request.Proxy = webProxy;

            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postBytes.Length;
            request.CookieContainer = new CookieContainer();

            Stream requestStream = request.GetRequestStream();

            // now send it
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();

            // grab the response and print it out to the console along with the status code
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            return response.Cookies;
        }
    }
}
