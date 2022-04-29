namespace YoutubeMP3.UI
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_youtubedl = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox_links = new System.Windows.Forms.ListBox();
            this.textBox_link = new System.Windows.Forms.TextBox();
            this.label_link = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_youtubedl
            // 
            this.button_youtubedl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_youtubedl.Location = new System.Drawing.Point(298, 294);
            this.button_youtubedl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_youtubedl.Name = "button_youtubedl";
            this.button_youtubedl.Size = new System.Drawing.Size(159, 25);
            this.button_youtubedl.TabIndex = 0;
            this.button_youtubedl.Text = "youtube-dl ve ffmpeg güncelle";
            this.button_youtubedl.UseVisualStyleBackColor = true;
            this.button_youtubedl.Click += new System.EventHandler(this.button_youtubedl_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(298, 324);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(159, 11);
            this.progressBar1.TabIndex = 1;
            // 
            // listBox_links
            // 
            this.listBox_links.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_links.FormattingEnabled = true;
            this.listBox_links.Location = new System.Drawing.Point(9, 91);
            this.listBox_links.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox_links.Name = "listBox_links";
            this.listBox_links.Size = new System.Drawing.Size(450, 199);
            this.listBox_links.TabIndex = 6;
            // 
            // textBox_link
            // 
            this.textBox_link.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_link.Location = new System.Drawing.Point(49, 56);
            this.textBox_link.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_link.Name = "textBox_link";
            this.textBox_link.Size = new System.Drawing.Size(259, 20);
            this.textBox_link.TabIndex = 3;
            // 
            // label_link
            // 
            this.label_link.AutoSize = true;
            this.label_link.Location = new System.Drawing.Point(8, 58);
            this.label_link.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_link.Name = "label_link";
            this.label_link.Size = new System.Drawing.Size(40, 13);
            this.label_link.TabIndex = 2;
            this.label_link.Text = "Adres :";
            // 
            // button_Add
            // 
            this.button_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Add.Location = new System.Drawing.Point(311, 56);
            this.button_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(71, 30);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Ekle";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Start
            // 
            this.button_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Start.Location = new System.Drawing.Point(356, 2);
            this.button_Start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(102, 50);
            this.button_Start.TabIndex = 7;
            this.button_Start.Text = "MP3\'e Dönüştür";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Clear.Location = new System.Drawing.Point(387, 55);
            this.button_Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(70, 31);
            this.button_Clear.TabIndex = 5;
            this.button_Clear.Text = "Temizle";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 294);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(285, 50);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(466, 353);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_link);
            this.Controls.Add(this.textBox_link);
            this.Controls.Add(this.listBox_links);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button_youtubedl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoutubeMP3";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_youtubedl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox_links;
        private System.Windows.Forms.TextBox textBox_link;
        private System.Windows.Forms.Label label_link;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

