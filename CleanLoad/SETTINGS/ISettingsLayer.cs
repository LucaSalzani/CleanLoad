using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanLoad
{
    public interface ISettingsLayer
    {
        string ProxyAddress { get; set; }
        string ProxyUsername { get; set; }
        string ProxyPassword { get; set; }
        bool IsProxyActive { get; set; }

        string UploadedUsername { get; set; }
        string UploadedPassword { get; set; }

        string DownloadPath { get; set; }


        // communication/ messaging

        event EventHandler<EventArgs> SETSaveSettings;
        event EventHandler<EventArgs> SETBrowseDLPath;

    }
}
