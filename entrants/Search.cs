using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entrants
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Count count = new Count();
            count.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AvScore avScore = new AvScore();
            avScore.Show();
            Hide();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Top_5 top_5 = new Top_5();
            top_5.Show();
            Hide();
        }
    }
}
