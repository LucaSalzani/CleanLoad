using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanLoad
{
    public interface IDownloaderLayer
    {
        List<DLFile> DLListView { get; set; }
        string GlobalStatus { get; set; }
        string DLButtonStartStop { get; set; }

        event EventHandler<DownloadEventArgs> DLStartStop;
        event EventHandler<LinksEventArgs> DLGetDataFromLINK;

        void DLViewUpdatePercentage(DLFile dlFile, int percentage);

    }
}
