using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace CleanLoad
{
    public class LinksEventArgs : EventArgs
    {
        private readonly List<string> _listDL;
        private readonly WebProxy _webProxy;
        private readonly ULAccount _ulAccount;

        public LinksEventArgs(List<string> listDL, WebProxy webProxy, ULAccount ulAccount)
        {
            _listDL = listDL;
            _webProxy = webProxy;
            _ulAccount = ulAccount;
        }

        public List<string> ListDL
        {
            get { return _listDL; }
        }

        public WebProxy WEBProxy
        {
            get { return _webProxy; }
        }

        public ULAccount ULAccount
        {
            get { return _ulAccount; }
        }
    }
}
