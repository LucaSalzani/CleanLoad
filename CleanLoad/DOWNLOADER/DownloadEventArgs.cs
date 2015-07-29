using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace CleanLoad
{
    public class DownloadEventArgs : EventArgs
    {
        private readonly WebProxy _webProxy;
        private readonly ULAccount _ulAccount;
        private readonly string _dlPath;

        public DownloadEventArgs(WebProxy webProxy, ULAccount ulAccount, string dlPath)
        {
            _webProxy = webProxy;
            _ulAccount = ulAccount;
            _dlPath = dlPath;
        }

        public WebProxy WebProxy
        {
            get { return _webProxy; }
        }

        public ULAccount ULAccount
        {
            get { return _ulAccount; }
        }

        public string DLPath
        {
            get { return _dlPath; }
        }
    }
}
