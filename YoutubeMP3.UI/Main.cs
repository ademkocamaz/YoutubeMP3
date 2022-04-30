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
        private YoutubeService youtubeService;
        public Main()
        {
            InitializeComponent();
            youtubeService = new YoutubeService(richTextBox1, progressBar1,listBox_links);
        }

        private void button_youtubedl_Click(object sender, EventArgs e)
        {
            try
            {
                youtubeService.DownloadComponents();
            }
            catch (Exception exception)
            {
                LoggingTool.log.Error("youtubeService.DownloadComponents()", exception);
            }
            
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
            try
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
                    MessageBox.Show("Önce youtube-dl ve ffmpeg güncellemelisiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                youtubeService.DownloadMP3();
            }
            catch (Exception exception)
            {

                LoggingTool.log.Error("Hata oluştu.", exception);
            }
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoggingTool.log.Info("Program başladı.");
        }
    }
}
