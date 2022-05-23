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

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ошибка");
            }
            else
            {
                StreamWriter sw = new StreamWriter("entrants.txt", true);
                sw.WriteLine(textBox1.Text + " " + comboBox1.Text + " " + comboBox2.Text + " " + comboBox3.Text);
                sw.Close();

            }
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Count count = new Count();
            count.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Text = "name: " + "inf: " + "math: " + "rus: " + "\r\n";
            StreamReader sr = new StreamReader("entrants.txt");
            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                textBox2.Text += str + "\r\n";
            }
            sr.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AvScore avScore = new AvScore();
            avScore.Show();
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Top_5 top_5 = new Top_5();
            top_5.Show();
            Hide();

        }
    }
}
/*
 * 
 */