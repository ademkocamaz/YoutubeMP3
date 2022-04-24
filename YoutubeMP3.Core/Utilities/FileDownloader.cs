using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeMP3.Core
{
    public class FileDownloader
    {
        ProgressBar progressBar;

        public FileDownloader(ProgressBar progressBar)
        {
            this.progressBar = progressBar;
        }
        public void Download(string uri, string fileName)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            using (WebClient wc = new WebClient())
            {
                
                wc.DownloadProgressChanged += (o, e) =>
                {
                    progressBar.Value = e.ProgressPercentage;
                };
                wc.DownloadFileCompleted += (o, e) =>
                {
                    progressBar.Value = 0;                   
                };
                //wc.DownloadFileAsync(new Uri(uri), fileName);
                wc.DownloadFileAsync(new Uri(uri), fileName);
                while (wc.IsBusy)
                {
                    Application.DoEvents();
                }
                
            }
        }
    }
}
