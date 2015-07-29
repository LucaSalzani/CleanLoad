using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;

namespace CleanLoad
{
    public class DLC
    {
        private string filepath;
        private string allContentText;
        private WebProxy myProxy;

        public DLC(string filepath, WebProxy myProxy)
        {
            this.filepath = filepath;
            this.myProxy = myProxy;
            this.allContentText = File.ReadAllText(this.filepath);
        }

        public List<string> decryptContainer()
        {
            // this is what we are sending
            string post_data = "content=" + Uri.EscapeDataString(allContentText);

            // this is where we will send it
            string uri = "http://dcrypt.it/decrypt/paste";

            // create a request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.KeepAlive = false;
            request.ProtocolVersion = HttpVersion.Version10;
            request.Method = "POST";

            // turn our request string into a byte stream
            byte[] postBytes = Encoding.ASCII.GetBytes(post_data);


            //Proxy
            //VALIDATE: Proxy needed or not?
            request.Proxy = myProxy;


            // this is important - make sure you specify type this way
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = postBytes.Length;

            Stream requestStream = request.GetRequestStream();

            // now send it
            requestStream.Write(postBytes, 0, postBytes.Length);
            requestStream.Close();


            // grab te response and print it out to the console along with the status code
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string line = "";
            StreamReader sr = new StreamReader(response.GetResponseStream());
            List<string> dlLinks = new List<string>();
            while ((line = sr.ReadLine()) != null)
            {
                Regex regex = new Regex(@"(http|ftp|https)://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?");
                Match match = regex.Match(line);

                if (match.Success)
                    dlLinks.Add(match.Value);
            }

            return dlLinks;
        }
    }
}
