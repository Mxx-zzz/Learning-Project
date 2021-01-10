using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace TimeNow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public long Year, Month, Day, Hour, Minte, Second;

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "2022/2/4  00:00:00" + "   星期五";
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            DateTime dong_time = Convert.ToDateTime(Convert.ToDateTime("2022-2-4 00:00:00"));
            textBox1.Text = DateTime.Now.ToString();
            textBox3.Text = DateAndTime.DateDiff("yyyy", dateTime, dong_time,
                FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1).ToString();
            textBox4.Text = DateAndTime.DateDiff("m", dateTime, dong_time,
                FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1).ToString();
            textBox5.Text = DateAndTime.DateDiff("d", dateTime, dong_time,
                FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1).ToString();
            textBox6.Text = DateAndTime.DateDiff("h", dateTime, dong_time,
                FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1).ToString();
            textBox7.Text = DateAndTime.DateDiff("n", dateTime, dong_time,
                FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1).ToString();
            textBox8.Text = DateAndTime.DateDiff("s", dateTime, dong_time,
                FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1).ToString();
        }

    }
}
