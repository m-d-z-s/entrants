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
    public partial class Form1 : Form
    {
        public List<string> l = new List<string>();
        int ball_inf_3;
        int ball_inf_4;
        int ball_inf_5;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (textBox1.Text == "")
            {
                MessageBox.Show("ошибка");
            }
            else
            {
                StreamWriter sw = new StreamWriter("entrants.txt", true);
                sw.WriteLine(textBox1.Text + " " + comboBox1.Text + " " + comboBox2.Text + " " + comboBox3.Text);
                sw.Close();
                l.Add(Convert.ToString(ball_inf_3 + ball_inf_4 + ball_inf_5));

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("entrants.txt");
            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                string[] mas = str.Split();
                if (mas[1] == "3")
                {
                    ball_inf_3 += 1; 
                }
                if (mas[1] == "4")
                {
                    ball_inf_4 += 1;

                }
                if (mas[1] == "5")
                {
                    ball_inf_5 += 1;

                }

            }

            sr.Close();
            //l.Add(Convert.ToString(ball_inf_3 + ball_inf_4 + ball_inf_5));
            StreamWriter sw = new StreamWriter("ball.txt", true);
            for (int i = 0; i < l.Count; i++)
            {
                sw.WriteLine(ball_inf_3 + " " + ball_inf_4 + " " + ball_inf_5);
            }



        }
    }
}
/*
 * 
 */