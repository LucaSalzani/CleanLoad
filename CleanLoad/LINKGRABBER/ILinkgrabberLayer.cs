using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanLoad
{
    public interface ILinkgrabberLayer
    {
        string[] RawLinks { get; set; }
        List<string> CombinedLinks { get; set; }
        string DlcPath { get; set; }

        event EventHandler<ProxyEventArgs> LINKGetLinksFromDLC;
        event EventHandler<EventArgs> LINKGetLinksFromRaw;
        event EventHandler<EventArgs> LINKBrowseDLC;
        event EventHandler<EventArgs> LINKDeleteCombinedLinks;
    }
}
