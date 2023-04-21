using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer_Project
{
    public partial class Form1 : Form
    {
        private int h;
        private int m;
        private int s;
        private int i = 0;
        private int flag_min = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, System.EventArgs e)
        {
            h = hour_tr.Value;
            m = minute_tr.Value;
            s = second_tr.Value;
            timer.Interval = 1000;
            timer.Start();
            //timer_label_minute.Text = minute_tr.Value.ToString();
            //timer_label_hour.Text = hour_tr.Value.ToString();
            i = h * 3600 + m * 60 + s * 1;
            timer_label_second.Text = i.ToString();
            timer.Tick += Timer_Tick;
        }

        private void Minute_tr_ValueChanged(object sender, System.EventArgs e)
        {
            minute_l.Text = $"Minute: {minute_tr.Value}";
        }

        private void Second_tr_ValueChanged(object sender, System.EventArgs e)
        {
            second_l.Text = $"Second: {second_tr.Value}";
        }

        private void Hour_tr_ValueChanged(object sender, System.EventArgs e)
        {
            hour_l.Text = $"Hour: {hour_tr.Value}";
        }

        private void Timer_Tick(object sender, System.EventArgs e)
        {
            //if (i % 10 == 0)
            //{
            //    timer_label_second.Text = i.ToString();
            //}
            timer_label_second.Text = i.ToString();
            if (i == 0)
            {
                timer.Stop();
                hour_l.Text = $"Hour: {0}";
                minute_l.Text = $"Minute: {0}";
                second_l.Text = $"Second: {0}";
            }
            i--;
        }
    }
}
