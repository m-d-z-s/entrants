using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entrants
{
    public partial class Top_5 : Form
    {
        public List<string> top = new List<string>();
        public List<string> name = new List<string>();
        public List<int> marks = new List<int>();

        public Top_5()
        {
            InitializeComponent();
        }

        private void Top_5_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Count count = new Count();
            count.Show();
            Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AvScore avScore = new AvScore();
            avScore.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            StreamReader sr = new StreamReader("entrants.txt");
            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                string[] mas = str.Split();
                int count = Convert.ToInt32(mas[1]) + Convert.ToInt32(mas[2]) + Convert.ToInt32(mas[3]);
                marks.Add(count);
                name.Add(mas[0]);
            }
            sr.Close();

            for (int i = 0; i < marks.Count - 1; i++)
            {
                for (int j = 0; j < marks.Count - i - 1; j++)
                {
                    if (marks[j] > marks[j])
                    {
                        int b = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = b;
                    }
                }

            }
            for (int i = 0; i < 5; i++)
            {
                textBox1.Text += i+1 + ") " + name[i]+ " " + marks[i] + "\r\n";
            }
        }
    }
}
