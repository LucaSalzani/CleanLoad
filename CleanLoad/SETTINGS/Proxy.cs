using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace CleanLoad
{
    public class Proxy
    {
        private string proxyAddress;
        private string username;
        private string password;
        private bool isActive;

        public string ProxyAddress
        {
            get { return proxyAddress; }
            set { proxyAddress = value; }
        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        public Proxy(string address, bool active)
        {
            proxyAddress = address;
            isActive = active;
            username = "";
            password = "";
        }

        public Proxy(string address, bool active, string user, string pw)
        {
            proxyAddress = address;
            isActive = active;
            username = user;
            password = pw;
        }

        public WebProxy GetProxyToUse()
        {
            WebProxy currentProxy = new WebProxy();
            if (isActive)
            {
                Uri newUri = new Uri(proxyAddress);
                currentProxy.Address = newUri;
                if (!String.IsNullOrEmpty(username))
                    currentProxy.Credentials = new NetworkCredential(username, password);
            }
            else
            {
                currentProxy = null;
            }

            return currentProxy;
        }
    }
}
