using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace entrants
{
    public partial class AvScore : Form
    {
        double avscore;
        public AvScore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("entrants.txt");
            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                string[] mas = str.Split();
                avscore = Convert.ToDouble(Convert.ToInt32(mas[1]) + Convert.ToInt32(mas[2]) + Convert.ToInt32(mas[3])) / 3.0;

                if (Convert.ToDouble(numericUpDown1.Value) < avscore)
                {
                    textBox1.Text += "name: " + mas[0] + " avscore = " + avscore + "\r\n";
                    avscore = 0;
                }
                avscore = 0;
            }
            sr.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Count count = new Count();
            count.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Top_5 top_5 = new Top_5();
            top_5.Show();
            Hide();

        }
    }
}
