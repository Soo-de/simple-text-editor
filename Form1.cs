//***********************************************************************************************************************
//**                                                                                                                   **
//**                                     SAKARYA ÜNÝVERSÝTESÝ                                                          **
//**                          BÝLGÝSAYAR VE BÝLÝÞÝM BÝLÝMLERÝ FAKÜLTESÝ                                                **
//**                                BÝLGÝSAYAR MÜHENDÝSLÝÐÝ BÖLÜMÜ                                                     **
//**                                                                                                                   **
//**                                  ÖDEV NUMARASI..: 1                                                               **
//**                                  ÖÐRENCÝ ADI.....: SUDE ANDURMAN                                                  **
//**                                  ÖÐRENCÝ NUMARASI: b231210005                                                     **
//**                                  DERS GRUBU......: B                                                              **
//**                                                                                                                   ** 
//**                                                                                                                   **  
//**                       Amaç:Basit bir kelime iþlem programý gerçekleþtirmek                                        **
//**                                                                                                                   **
//**                                                                                                                   **  
//**                                                                                                                   **
//***********************************************************************************************************************


namespace NDP_1._ODEV
{

    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (i != 100)
            {
                i++;
                if (i == 75)
                {
                    /* basic unlock effect*/
                    pictureBox2.Show();
                    pictureBox1.Hide();
                }
            }
            else
            {
                /*shifting screen */
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                timer1.Stop();
            }
        }

    }
}
