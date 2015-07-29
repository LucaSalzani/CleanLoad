using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace CleanLoad
{
    public class ProxyEventArgs : EventArgs
    {
        private readonly WebProxy _webProxy;

        public ProxyEventArgs(WebProxy webProxy)
        {
            _webProxy = webProxy;
        }

        public WebProxy WebProxy
        {
            get { return _webProxy; }
        }
    }
}
