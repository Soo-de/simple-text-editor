//***********************************************************************************************************************
//**                                                                                                                   **
//**                                     SAKARYA �N�VERS�TES�                                                          **
//**                          B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�                                                **
//**                                B�LG�SAYAR M�HEND�SL��� B�L�M�                                                     **
//**                                                                                                                   **
//**                                  �DEV NUMARASI..: 1                                                               **
//**                                  ��RENC� ADI.....: SUDE ANDURMAN                                                  **
//**                                  ��RENC� NUMARASI: b231210005                                                     **
//**                                  DERS GRUBU......: B                                                              **
//**                                                                                                                   ** 
//**                                                                                                                   **  
//**                       Ama�:Basit bir kelime i�lem program� ger�ekle�tirmek                                        **
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
