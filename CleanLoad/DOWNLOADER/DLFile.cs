using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;

namespace CleanLoad
{
    public class DLFile
    {
        private string _dlURL;
        private string _id;
        private StatusEnum _status;
        private string _dlPath;
        private WebProxy _webProxy;
        private CookieCollection _cookieJar;

        private string _directDownloadLink;

        public string DirectDownloadLink
        {
            get { return _directDownloadLink; }
        }
        public StatusEnum Status
        {
            get { return _status; }
        }
        public string DlURL
        {
            get { return _dlURL; }
        }


        public DLFile(string dlURL, StatusEnum status, string dlPath, WebProxy webProxy, CookieCollection cookieJar)
        {
            _dlURL = dlURL;
            _status = status;
            _dlPath = dlPath;
            _webProxy = webProxy;
            _cookieJar = cookieJar;

            _id = null;
        }

        public void GetID()
        {
            Regex regex = new Regex(@"/(\w{8})(/|$|\n)");
            Match match = regex.Match(_dlURL);

            _id = match.Groups[1].ToString();
        }

        public void GetDirectDownloadLink()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://uploaded.net/file/" + _id + "/ddl");

            if (_webProxy != null)
                request.Proxy = _webProxy;

            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(_cookieJar);


            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();

            // Clean up the streams and the response.
            reader.Close();
            response.Close();

            Regex regex = new Regex("http://[0-9a-z\\-]*stor\\d+.uploaded.net/dl/([0-9a-z-]+)");
            Match match = regex.Match(responseFromServer);

            //VALIDATE: ERROR at failure. No link (match.Success)

            _directDownloadLink = match.Value;
        }

        public void DownloadFileFromUL(ref BackgroundWorker worker)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_directDownloadLink);

            if (_webProxy != null)
                request.Proxy = _webProxy;

            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(_cookieJar);


            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Regex regex = new Regex("attachment; filename=\"([^\\\\/\\:\\*\\?\\\"\\<\\>\\|]+)\"");
            Match match = regex.Match(response.GetResponseHeader("Content-Disposition"));

            string filename = match.Groups[1].ToString();

            //Create a stream for the file
            Stream instream = null;
            Stream outstream = File.Create(Path.Combine(_dlPath, filename));


            //Get the Stream returned from the response
            instream = response.GetResponseStream();

            byte[] buffer = new byte[8 * 1024];
            int len;
            while ((len = instream.Read(buffer, 0, buffer.Length)) > 0)
            {
                outstream.Write(buffer, 0, len);
            }
            instream.Close();
            outstream.Close();

            _status = StatusEnum.Done;
        }
    }
}
