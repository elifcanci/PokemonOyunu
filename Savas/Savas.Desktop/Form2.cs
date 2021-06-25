// Nesneye Dayalı Programlama Proje Ödevi
// AD SOYAD: Elif CANCI
// b191200017

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Savas.Desktop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string fileName = "BestFiveScores";

            if (!File.Exists(fileName))
            {
                File.WriteAllLines(fileName, new List<string>() { "0", "0", "0", "0", "0" });
            }

            List<string> lines = File.ReadAllLines(fileName).ToList();

            List<Label> bestfivescores = new List<Label>();

            foreach (Label item in panel1.Controls)
            {
                bestfivescores.Add(item);
            }
            for (int i = 0; i < 5; i++)
            {
                bestfivescores[(4 - i)].Text = lines[i];
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
