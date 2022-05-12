using SlavaGu.ConsoleAppLauncher;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeMP3.Core;
using YoutubeMP3.Core.Utilities;

namespace YoutubeMP3.UI
{
    internal class YoutubeService
    {
        private RichTextBox richTextBox;
        private ProgressBar progressBar;
        private ListBox listBox;

        public YoutubeService(RichTextBox richTextBox, ProgressBar progressBar, ListBox listBox)
        {
            this.richTextBox = richTextBox;
            this.progressBar = progressBar;
            this.listBox = listBox;
        }

        public async void DownloadComponents()
        {
            richTextBox.Text = "Downloading youtube-dl.exe and ffmpeg-release-essentials.7z";
            LoggingTool.log.Info("Downloading youtube-dl.exe and ffmpeg-release-essentials.7z");
            await Task.Run(() =>
            {
                if (File.Exists("youtube-dl.exe"))
                {
                    File.Delete("youtube-dl.exe");
                }
                if (File.Exists("ffmpeg.exe"))
                {
                    File.Delete("ffmpeg.exe");
                }
                if (File.Exists("ffprobe.exe"))
                {
                    File.Delete("ffprobe.exe");
                }
                if (File.Exists("ffmpeg-release-essentials.7z"))
                {
                    File.Delete("ffmpeg-release-essentials.7z");
                }

                //FileDownloader fd = new FileDownloader(progressBar);

                //fd.Download("https://youtube-dl.org/downloads/latest/youtube-dl.exe", "youtube-dl.exe");
                //fd.Download("https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.7z", "ffmpeg-release-essentials.7z");


                ConsoleApp app = new ConsoleApp("wget.exe", "-q --show-progress https://yt-dl.org/downloads/latest/youtube-dl.exe");
                app.ConsoleOutput += App_ConsoleOutput;
                app.Run();
                app.WaitForExit();

                app = new ConsoleApp("wget.exe", "-q --show-progress https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.7z");
                app.ConsoleOutput += App_ConsoleOutput;
                app.Run();
                app.WaitForExit();

            });

            await Task.Run(Extract);

            richTextBox.Text = "Güncelleme başarıyla tamamlandı.";
            LoggingTool.log.Info("Güncelleme başarıyla tamamlandı.");
            progressBar.Value = 100;
        }

        public async void DownloadMP3()
        {
            await Task.Run(() =>
            {
                ConsoleApp app = new ConsoleApp("youtube-dl.exe", "--verbose --extract-audio --audio-format mp3 --batch-file url.txt");
                app.ConsoleOutput += App_ConsoleOutput;
                app.Run();
                app.WaitForExit();
                richTextBox.Text = "İndirme başarıyla tamamlandı.";
                LoggingTool.log.Info("İndirme başarıyla tamamlandı.");
                listBox.Items.Clear();
            });

        }
        private void App_ConsoleOutput(object sender, ConsoleOutputEventArgs e)
        {
            richTextBox.Text = e.Line;
            LoggingTool.log.Info(e.Line);
        }

        //private void Extract(Action<string> replyHandler)
        //{
        //    ConsoleApp app = new ConsoleApp("7z.exe", "e -r ffmpeg-release-essentials.7z ffmpeg.exe ffprobe.exe");
        //    app.ConsoleOutput += App_ConsoleOutput;    
        //    app.Run();
        //    app.WaitForExit();
        //}
        public void Extract()
        {
            progressBar.Value = 70;
            ConsoleApp app = new ConsoleApp("7z.exe", "e -r ffmpeg-release-essentials.7z ffmpeg.exe ffprobe.exe");
            app.ConsoleOutput += App_ConsoleOutput;
            app.Run();
            app.WaitForExit();
            if (File.Exists("ffmpeg-release-essentials.7z"))
            {
                File.Delete("ffmpeg-release-essentials.7z");
            }
        }
    }
}
