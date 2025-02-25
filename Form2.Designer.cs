namespace NDP_1._ODEV
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            richTextBox1 = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            kesToolStripMenuItem1 = new ToolStripMenuItem();
            kToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem1 = new ToolStripMenuItem();
            değiştirToolStripMenuItem = new ToolStripMenuItem();
            yazıTipiniDeğiştirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            dosyaToolStripMenuItem = new ToolStripMenuItem();
            yeniToolStripMenuItem = new ToolStripMenuItem();
            dosyaToolStripMenuItem1 = new ToolStripMenuItem();
            dosyaKaydetToolStripMenuItem = new ToolStripMenuItem();
            çıkışToolStripMenuItem = new ToolStripMenuItem();
            biçimToolStripMenuItem = new ToolStripMenuItem();
            kesToolStripMenuItem = new ToolStripMenuItem();
            kopyalaToolStripMenuItem = new ToolStripMenuItem();
            yapıştırToolStripMenuItem = new ToolStripMenuItem();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            renkToolStripMenuItem = new ToolStripMenuItem();
            yazıRengiToolStripMenuItem = new ToolStripMenuItem();
            fontRengiToolStripMenuItem = new ToolStripMenuItem();
            yazıÇeşidiToolStripMenuItem = new ToolStripMenuItem();
            fontDialog1 = new FontDialog();
            colorDialog1 = new ColorDialog();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            toolStrip1 = new ToolStrip();
            KestoolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.ContextMenuStrip = contextMenuStrip1;
            richTextBox1.Location = new Point(12, 63);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 375);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { kesToolStripMenuItem1, kToolStripMenuItem, yapıştırToolStripMenuItem1, değiştirToolStripMenuItem, yazıTipiniDeğiştirToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(219, 134);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // kesToolStripMenuItem1
            // 
            kesToolStripMenuItem1.Image = Resource1.cut;
            kesToolStripMenuItem1.Name = "kesToolStripMenuItem1";
            kesToolStripMenuItem1.Size = new Size(218, 26);
            kesToolStripMenuItem1.Text = "Kes";
            kesToolStripMenuItem1.Click += kesToolStripMenuItem1_Click;
            // 
            // kToolStripMenuItem
            // 
            kToolStripMenuItem.Image = Resource1.copy;
            kToolStripMenuItem.Name = "kToolStripMenuItem";
            kToolStripMenuItem.Size = new Size(218, 26);
            kToolStripMenuItem.Text = "Kopyala";
            kToolStripMenuItem.Click += kToolStripMenuItem_Click;
            // 
            // yapıştırToolStripMenuItem1
            // 
            yapıştırToolStripMenuItem1.Image = Resource1.paste;
            yapıştırToolStripMenuItem1.Name = "yapıştırToolStripMenuItem1";
            yapıştırToolStripMenuItem1.Size = new Size(218, 26);
            yapıştırToolStripMenuItem1.Text = "Yapıştır";
            yapıştırToolStripMenuItem1.Click += yapıştırToolStripMenuItem1_Click;
            // 
            // değiştirToolStripMenuItem
            // 
            değiştirToolStripMenuItem.Image = Resource1.shift_color;
            değiştirToolStripMenuItem.Name = "değiştirToolStripMenuItem";
            değiştirToolStripMenuItem.Size = new Size(218, 26);
            değiştirToolStripMenuItem.Text = "Yazı Rengini Değiştir";
            değiştirToolStripMenuItem.Click += değiştirToolStripMenuItem_Click;
            // 
            // yazıTipiniDeğiştirToolStripMenuItem
            // 
            yazıTipiniDeğiştirToolStripMenuItem.Image = Resource1.shift_font;
            yazıTipiniDeğiştirToolStripMenuItem.Name = "yazıTipiniDeğiştirToolStripMenuItem";
            yazıTipiniDeğiştirToolStripMenuItem.Size = new Size(218, 26);
            yazıTipiniDeğiştirToolStripMenuItem.Text = "Yazı Tipini Değiştir";
            yazıTipiniDeğiştirToolStripMenuItem.Click += yazıTipiniDeğiştirToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dosyaToolStripMenuItem, biçimToolStripMenuItem, ayarlarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            dosyaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yeniToolStripMenuItem, dosyaToolStripMenuItem1, dosyaKaydetToolStripMenuItem, çıkışToolStripMenuItem });
            dosyaToolStripMenuItem.Image = Resource1.Folder;
            dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            dosyaToolStripMenuItem.Size = new Size(84, 24);
            dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // yeniToolStripMenuItem
            // 
            yeniToolStripMenuItem.Image = Resource1._new;
            yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            yeniToolStripMenuItem.Size = new Size(183, 26);
            yeniToolStripMenuItem.Text = "Yeni";
            yeniToolStripMenuItem.Click += yeniToolStripMenuItem_Click;
            // 
            // dosyaToolStripMenuItem1
            // 
            dosyaToolStripMenuItem1.Image = Resource1.Opened_Folder;
            dosyaToolStripMenuItem1.Name = "dosyaToolStripMenuItem1";
            dosyaToolStripMenuItem1.Size = new Size(183, 26);
            dosyaToolStripMenuItem1.Text = "Dosya Aç";
            dosyaToolStripMenuItem1.Click += dosyaToolStripMenuItem1_Click;
            // 
            // dosyaKaydetToolStripMenuItem
            // 
            dosyaKaydetToolStripMenuItem.Image = Resource1.save;
            dosyaKaydetToolStripMenuItem.Name = "dosyaKaydetToolStripMenuItem";
            dosyaKaydetToolStripMenuItem.Size = new Size(183, 26);
            dosyaKaydetToolStripMenuItem.Text = "Dosya Kaydet";
            dosyaKaydetToolStripMenuItem.Click += dosyaKaydetToolStripMenuItem_Click;
            // 
            // çıkışToolStripMenuItem
            // 
            çıkışToolStripMenuItem.Image = Resource1.quit;
            çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            çıkışToolStripMenuItem.Size = new Size(183, 26);
            çıkışToolStripMenuItem.Text = "Çıkış";
            çıkışToolStripMenuItem.Click += çıkışToolStripMenuItem_Click;
            // 
            // biçimToolStripMenuItem
            // 
            biçimToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kesToolStripMenuItem, kopyalaToolStripMenuItem, yapıştırToolStripMenuItem });
            biçimToolStripMenuItem.Image = Resource1.Edit;
            biçimToolStripMenuItem.Name = "biçimToolStripMenuItem";
            biçimToolStripMenuItem.Size = new Size(80, 24);
            biçimToolStripMenuItem.Text = "Biçim";
            // 
            // kesToolStripMenuItem
            // 
            kesToolStripMenuItem.Image = Resource1.cut;
            kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            kesToolStripMenuItem.Size = new Size(146, 26);
            kesToolStripMenuItem.Text = "Kes";
            kesToolStripMenuItem.Click += kesToolStripMenuItem_Click;
            // 
            // kopyalaToolStripMenuItem
            // 
            kopyalaToolStripMenuItem.Image = Resource1.copy;
            kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            kopyalaToolStripMenuItem.Size = new Size(146, 26);
            kopyalaToolStripMenuItem.Text = "Kopyala";
            kopyalaToolStripMenuItem.Click += kopyalaToolStripMenuItem_Click;
            // 
            // yapıştırToolStripMenuItem
            // 
            yapıştırToolStripMenuItem.Image = Resource1.paste;
            yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            yapıştırToolStripMenuItem.Size = new Size(146, 26);
            yapıştırToolStripMenuItem.Text = "Yapıştır";
            yapıştırToolStripMenuItem.Click += yapıştırToolStripMenuItem_Click;
            // 
            // ayarlarToolStripMenuItem
            // 
            ayarlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { renkToolStripMenuItem, yazıÇeşidiToolStripMenuItem });
            ayarlarToolStripMenuItem.Image = Resource1.Settings;
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            ayarlarToolStripMenuItem.Size = new Size(90, 24);
            ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // renkToolStripMenuItem
            // 
            renkToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { yazıRengiToolStripMenuItem, fontRengiToolStripMenuItem });
            renkToolStripMenuItem.Image = Resource1.shift_color;
            renkToolStripMenuItem.Name = "renkToolStripMenuItem";
            renkToolStripMenuItem.Size = new Size(162, 26);
            renkToolStripMenuItem.Text = "Renk";
            // 
            // yazıRengiToolStripMenuItem
            // 
            yazıRengiToolStripMenuItem.Name = "yazıRengiToolStripMenuItem";
            yazıRengiToolStripMenuItem.Size = new Size(163, 26);
            yazıRengiToolStripMenuItem.Text = "Yazı Rengi";
            yazıRengiToolStripMenuItem.Click += yazıRengiToolStripMenuItem_Click;
            // 
            // fontRengiToolStripMenuItem
            // 
            fontRengiToolStripMenuItem.Name = "fontRengiToolStripMenuItem";
            fontRengiToolStripMenuItem.Size = new Size(163, 26);
            fontRengiToolStripMenuItem.Text = "Font Rengi";
            fontRengiToolStripMenuItem.Click += fontRengiToolStripMenuItem_Click;
            // 
            // yazıÇeşidiToolStripMenuItem
            // 
            yazıÇeşidiToolStripMenuItem.Image = Resource1.shift_font;
            yazıÇeşidiToolStripMenuItem.Name = "yazıÇeşidiToolStripMenuItem";
            yazıÇeşidiToolStripMenuItem.Size = new Size(162, 26);
            yazıÇeşidiToolStripMenuItem.Text = "Yazı Çeşidi";
            yazıÇeşidiToolStripMenuItem.Click += yazıÇeşidiToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resource1.File;
            pictureBox2.Location = new Point(12, 32);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resource1.Bookmark;
            pictureBox1.Location = new Point(43, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resource1.Document;
            pictureBox3.Location = new Point(74, 31);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { KestoolStripButton1, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // KestoolStripButton1
            // 
            KestoolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            KestoolStripButton1.Image = Resource1.cut;
            KestoolStripButton1.ImageTransparentColor = Color.Magenta;
            KestoolStripButton1.Name = "KestoolStripButton1";
            KestoolStripButton1.Size = new Size(29, 24);
            KestoolStripButton1.Text = "KestoolStripButton1";
            KestoolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = Resource1.copy;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "KopyalatoolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = Resource1.paste;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "YapıstırtoolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TextBelgesi";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dosyaToolStripMenuItem;
        private ToolStripMenuItem yeniToolStripMenuItem;
        private ToolStripMenuItem dosyaToolStripMenuItem1;
        private ToolStripMenuItem dosyaKaydetToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private ToolStripMenuItem biçimToolStripMenuItem;
        private ToolStripMenuItem kesToolStripMenuItem;
        private ToolStripMenuItem kopyalaToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem renkToolStripMenuItem;
        private ToolStripMenuItem yazıRengiToolStripMenuItem;
        private ToolStripMenuItem fontRengiToolStripMenuItem;
        private ToolStripMenuItem yazıÇeşidiToolStripMenuItem;
        private FontDialog fontDialog1;
        private ColorDialog colorDialog1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem kesToolStripMenuItem1;
        private ToolStripMenuItem kToolStripMenuItem;
        private ToolStripMenuItem yapıştırToolStripMenuItem1;
        private ToolStripMenuItem değiştirToolStripMenuItem;
        private ToolStripMenuItem yazıTipiniDeğiştirToolStripMenuItem;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private ToolStrip toolStrip1;
        private ToolStripButton KestoolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}