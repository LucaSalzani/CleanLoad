using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanLoad
{
    public class LinksEventArgs : EventArgs
    {
        private readonly List<string> _listDL;

        public LinksEventArgs(List<string> listDL)
        {
            _listDL = listDL;
        }

        public List<string> ListDL
        {
            get { return _listDL; }
        }

    }
}
