//***********************************************************************************************************************
//**                                                                                                                   **
//**                                     SAKARYA ÜNİVERSİTESİ                                                          **
//**                          BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ                                                **
//**                                BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ                                                     **
//**                                                                                                                   **
//**                                  ÖDEV NUMARASI..: 1                                                               **
//**                                  ÖĞRENCİ ADI.....: SUDE ANDURMAN                                                  **
//**                                  ÖĞRENCİ NUMARASI: b231210005                                                     **
//**                                  DERS GRUBU......: B                                                              **
//**                                                                                                                   ** 
//**                                                                                                                   **  
//**                       Amaç:Basit bir kelime işlem programı gerçekleştirmek                                        **
//**                                                                                                                   **
//**                                                                                                                   **  
//**                                                                                                                   **
//***********************************************************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NDP_1._ODEV
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void fontRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* to show color options*/
            colorDialog1.ShowDialog();
            /*to alter background color*/
            richTextBox1.SelectionBackColor = colorDialog1.Color;
        }

        private void yazıÇeşidiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*to show font options*/
            fontDialog1.ShowDialog();
            /*to change font*/
            richTextBox1.SelectionFont = fontDialog1.Font;
        }

        private void yazıRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* to show color options */
            colorDialog1.ShowDialog();
            /* to shift text color */
            richTextBox1.SelectionColor = colorDialog1.Color;
        }
        private void değiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* to show color options */
            colorDialog1.ShowDialog();
            /* to shift text color */
            richTextBox1.SelectionColor = colorDialog1.Color;

        }
        private void yazıTipiniDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*to show font options*/
            fontDialog1.ShowDialog();
            /*to change font*/
            richTextBox1.SelectionFont = fontDialog1.Font;
        }


        private void kesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void yeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* For offering an option to see multiple forms */
            DialogResult result1 = MessageBox.Show("Mevcut ekran kapatılsın mı ?", "Yeni Form Oluştur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)/* If result is yes, closing the old form */
            {
                if (string.IsNullOrEmpty(saveFileDialog1.FileName))/* checking whether the old file is saved */
                {
                    DialogResult result2 = MessageBox.Show("MEVCUT OLAN DOSYAYI HENÜZ KAYDETMEDİNİZ \n DEVAM ETMEK İSTER MİSİNİZ ?", "DİKKAT!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result2 == DialogResult.Yes)
                    {
                        this.Hide();
                        Form2 newForm = new Form2();
                        newForm.ShowDialog();
                    }
                }
                else
                {
                    /* if the file already saved, making sure that we saved the last version of it */
                    DialogResult result3=MessageBox.Show("MEVCUT OLAN DOSYAYI KAYDETMEK İSTER MİSİNİZ ?", "DOSYA KAYDI ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result3 == DialogResult.Yes)
                    {
                        File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                        this.Hide();
                        Form2 newForm = new Form2();
                        newForm.ShowDialog();
                    }
                    else
                    {
                        /* if the user dont  want to save the last version*/
                        this.Hide();
                        Form2 newForm = new Form2();
                        newForm.ShowDialog();
                    }
                }
            }
            else
            {
                /* if user wants to see multiple screen*/
                Form2 newForm = new Form2();
                newForm.ShowDialog();
            }
        }

        private void dosyaKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                // For the first time saving
                saveFileDialog1.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";
                saveFileDialog1.Title = "Dosyayı Kaydet";
                saveFileDialog1.ShowDialog();
            }
            if (saveFileDialog1.FileName != "")
            {
                // For the already saved ones
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void dosyaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            /*to determine file type*/ 
            openFileDialog1.Filter = "Metin Dosyaları|*.txt|Tüm Dosyalar|*.*";
            openFileDialog1.Title = "Dosyayı Aç";
            /*to show files*/
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                /* To show the wanted file*/ 
                string fileContent = File.ReadAllText(openFileDialog1.FileName);
                richTextBox1.Text = fileContent;
            }
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(saveFileDialog1.FileName))/* checking whether the file is saved */
            {
                DialogResult result2 = MessageBox.Show("MEVCUT OLAN DOSYAYI HENÜZ KAYDETMEDİNİZ \n DEVAM ETMEK İSTER MİSİNİZ ?", "DİKKAT!! ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result2 == DialogResult.Yes)/* if the user does'nt want to save file */
                {
                    Application.Exit();
                }
            }
            else
            {
                DialogResult result3 = MessageBox.Show("MEVCUT OLAN DOSYAYI KAYDETMEK İSTER MİSİNİZ?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result3 == DialogResult.Yes)
                {
                    /*save and close*/
                    File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                    Application.Exit();
                }
                else
                    Application.Exit();
            }
        }


        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
