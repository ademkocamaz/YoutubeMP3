using SlavaGu.ConsoleAppLauncher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeMP3.Core;
using YoutubeMP3.Core.Utilities;

namespace YoutubeMP3.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private async void DownloadComponents()
        {
            richTextBox1.Text = "Downloading youtube-dl.exe and ffmpeg-release-essentials.7z";
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
                FileDownloader fd = new FileDownloader(progressBar1);
                fd.Download("https://youtube-dl.org/downloads/latest/youtube-dl.exe", "youtube-dl.exe");
                fd.Download("https://www.gyan.dev/ffmpeg/builds/ffmpeg-release-essentials.7z", "ffmpeg-release-essentials.7z");
                //Extract(reply => BeginInvoke((MethodInvoker)delegate { listBox_links.Items.Add(reply); }));
                
            });

            await Task.Run(Extract);

            richTextBox1.Text = "Güncelleme başarıyla tamamlandı.";
            LoggingTool.log.Info("Güncelleme başarıyla tamamlandı.");
            progressBar1.Value = 100;
        }

        private async void DownloadMP3()
        {
            await Task.Run(() =>
            {
                ConsoleApp app = new ConsoleApp("youtube-dl.exe", "--verbose --extract-audio --audio-format mp3 --batch-file url.txt");
                app.ConsoleOutput += App_ConsoleOutput;
                app.Run();
                app.WaitForExit();
                richTextBox1.Text = "İndirme başarıyla tamamlandı.";
                LoggingTool.log.Info("İndirme başarıyla tamamlandı.");
                listBox_links.Items.Clear();
            });
            
        }

        private void App_ConsoleOutput(object sender, ConsoleOutputEventArgs e)
        {
            richTextBox1.Text = e.Line;
            LoggingTool.log.Info(e.Line);
        }

        private void Extract()
        {
            progressBar1.Value = 70;
            ConsoleApp app = new ConsoleApp("7z.exe", "e -r ffmpeg-release-essentials.7z ffmpeg.exe ffprobe.exe");
            app.ConsoleOutput += App_ConsoleOutput;
            app.Run();
            app.WaitForExit();
            if (File.Exists("ffmpeg-release-essentials.7z"))
            {
                File.Delete("ffmpeg-release-essentials.7z");
            }
        }
        //private void Extract(Action<string> replyHandler)
        //{
        //    ConsoleApp app = new ConsoleApp("7z.exe", "e -r ffmpeg-release-essentials.7z ffmpeg.exe ffprobe.exe");
        //    app.ConsoleOutput += App_ConsoleOutput;    
        //    app.Run();
        //    app.WaitForExit();
        //}


        private void button_youtubedl_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 20;
            DownloadComponents();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            listBox_links.Items.Add(textBox_link.Text);
            textBox_link.Text = "";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            listBox_links.Items.Clear();
            textBox_link.Text = "";
        }

        private void button_Start_Click(object sender, EventArgs e)
        {
            if (listBox_links.Items.Count == 0)
            {
                return;
            }
            StreamWriter saveFile = new StreamWriter("url.txt");
            foreach (var item in listBox_links.Items)
            {
                saveFile.WriteLine(item.ToString());
            }
            saveFile.Close();

            if (!File.Exists("youtube-dl.exe") | !File.Exists("ffmpeg.exe") | !File.Exists("ffprobe.exe"))
            {
                MessageBox.Show("Önce youtube-dl ve ffmpeg güncellemelisiniz.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            DownloadMP3();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoggingTool.log.Info("Program başladı.");
        }
    }
}
