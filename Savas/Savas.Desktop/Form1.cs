// Nesneye Dayalı Programlama Proje Ödevi
// AD SOYAD: Elif CANCI
// b191200017

using System;
using System.Windows.Forms;
using Savas.Library.Concrete;
using Savas.Library.Enum;

namespace Savas.Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            _oyun = new Oyun(ashPanel, savasAlaniPanel);
            _oyun.GecenSureDegisti += Oyun_GecenSureDegisti;
            _oyun.SkorDegisti += Oyun_SkorDegisti;
        }

        private void Oyun_SkorDegisti(object sender, int skor)
        {
            Console.WriteLine(skor);
            label2.Text = skor.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private readonly Oyun _oyun;
       

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    _oyun.Baslat();
                    break;
                case Keys.Right:
                    _oyun.AshiHareketEttir(Yon.Saga);
                    break;
                case Keys.Left:
                    _oyun.AshiHareketEttir(Yon.Sola);
                    break;
                case Keys.Space:
                    _oyun.AtesEt();
                    break;
                case Keys.P: //pause tuşu basınca duruyo :)
                    _oyun.Pause();
                    break;
                case Keys.R: //pause tuşu basınca duruyo :)
                    _oyun.Resume();
                    break;
                case Keys.F:
                    SkorTablosunuGoster();
                    break;
            }
        }

        private void Oyun_GecenSureDegisti(object sender, EventArgs e)
        {
            sureLabel.Text = _oyun.GecenSure.ToString(@"m\:ss"); //@ koyduğumuz zaman 2 tane \ koymaya gerek kalmıyor.
            //$"{_oyun.GecenSure.Minutes}:{_oyun.GecenSure.Seconds.ToString("D2")}";    bu yazımda vardır.

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        public void SkorTablosunuGoster()
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
