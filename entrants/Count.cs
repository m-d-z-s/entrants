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
using System.Windows.Forms.DataVisualization.Charting;


namespace entrants
{
    public partial class Count : Form
    {
        public List<string> inf = new List<string>();
        public List<string> math = new List<string>();
        public List<string> rus = new List<string>();

        int ball_inf_3;
        int ball_inf_4;
        int ball_inf_5;
        int ball_math_3;
        int ball_math_4;
        int ball_math_5;
        int ball_rus_3;
        int ball_rus_4;
        int ball_rus_5;


        public Count()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ball_inf_3 = 0;
            ball_inf_4 = 0;
            ball_inf_5 = 0;

            StreamReader sr = new StreamReader("entrants.txt");
            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                string[] mas = str.Split();
                if (mas[1] == "3")
                {
                    ball_inf_3 += 1;
                }
                else if (mas[1] == "4")
                {
                    ball_inf_4 += 1;

                }
                else if (mas[1] == "5")
                {
                    ball_inf_5 += 1;

                }
                //MessageBox.Show(ball_inf_3 + " " + ball_inf_4 + " " + ball_inf_5);


            }
            inf.Add(Convert.ToString(ball_inf_3 + " " + ball_inf_4 + " " + ball_inf_5));
            sr.Close();
            StreamWriter sw = new StreamWriter("ball.txt", false);
            for (int i = 0; i < inf.Count; i++)
            {
                sw.WriteLine(ball_inf_3 + " " + ball_inf_4 + " " + ball_inf_5);
            }
            sw.Close();


            chart1.Series[0].ChartType = SeriesChartType.Pie;

            chart1.Series[0].Points.AddY(Convert.ToDouble(ball_inf_3));
            chart1.Series[0].Points.AddY(Convert.ToDouble(ball_inf_4));
            chart1.Series[0].Points.AddY(Convert.ToDouble(ball_inf_5));
            chart1.Series[0].Points[0].LegendText = "3";
            chart1.Series[0].Points[1].LegendText = "4";
            chart1.Series[0].Points[2].LegendText = "5";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ball_math_3 = 0;
            ball_math_4 = 0;
            ball_math_5 = 0;

            StreamReader sr = new StreamReader("entrants.txt");
            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                string[] mas = str.Split();
                if (mas[2] == "3")
                {
                    ball_math_3 += 1;
                }
                else if (mas[2] == "4")
                {
                    ball_math_4 += 1;

                }
                else if (mas[2] == "5")
                {
                    ball_math_5 += 1;

                }

            }
            math.Add(Convert.ToString(ball_math_3 + " " + ball_math_4 + " " + ball_math_5));
            sr.Close();
            StreamWriter sw = new StreamWriter("ball.txt", false);
            for (int i = 0; i < math.Count; i++)
            {
                sw.WriteLine(ball_math_3 + " " + ball_math_4 + " " + ball_math_5);
            }
            sw.Close();


            chart2.Series[0].ChartType = SeriesChartType.Pie;

            chart2.Series[0].Points.AddY(Convert.ToDouble(ball_math_3));
            chart2.Series[0].Points.AddY(Convert.ToDouble(ball_math_4));
            chart2.Series[0].Points.AddY(Convert.ToDouble(ball_math_5));
            chart2.Series[0].Points[0].LegendText = "3";
            chart2.Series[0].Points[1].LegendText = "4";
            chart2.Series[0].Points[2].LegendText = "5";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            ball_rus_3 = 0;
            ball_rus_4 = 0;
            ball_rus_5 = 0;

            StreamReader sr = new StreamReader("entrants.txt");
            while (!sr.EndOfStream)
            {
                string str = sr.ReadLine();
                string[] mas = str.Split();
                if (mas[3] == "3")
                {
                    ball_rus_3 += 1;
                }
                else if (mas[3] == "4")
                {
                    ball_rus_4 += 1;

                }
                else if (mas[3] == "5")
                {
                    ball_rus_5 += 1;

                }

            }
            rus.Add(Convert.ToString(ball_rus_3 + " " + ball_rus_4 + " " + ball_rus_5));
            sr.Close();
            StreamWriter sw = new StreamWriter("ball.txt", false);
            for (int i = 0; i < rus.Count; i++)
            {
                sw.WriteLine(ball_rus_3 + " " + ball_rus_4 + " " + ball_rus_5);
            }
            sw.Close();


            chart3.Series[0].ChartType = SeriesChartType.Pie;

            chart3.Series[0].Points.AddY(Convert.ToDouble(ball_rus_3));
            chart3.Series[0].Points.AddY(Convert.ToDouble(ball_rus_4));
            chart3.Series[0].Points.AddY(Convert.ToDouble(ball_rus_5));
            chart3.Series[0].Points[0].LegendText = "RUS 3";
            chart3.Series[0].Points[1].LegendText = "RUS 4";
            chart3.Series[0].Points[2].LegendText = "RUS 5";

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
