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
        int max = 15;

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
            StreamReader sr = new StreamReader("entrants.txt");
            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                string[] mas = str.Split();
                //MessageBox.Show(ball_inf_3 + " " + ball_inf_4 + " " + ball_inf_5);



            }
            sr.Close();

        }
    }
}
