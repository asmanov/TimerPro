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
            timer.Interval = h * 3600 + m * 60 + s * 1;
            timer.Start();
            timer_label_second.Text = second_tr.Value.ToString();
            timer_label_minute.Text = minute_tr.Value.ToString();
            timer_label_hour.Text = hour_tr.Value.ToString();
            i = timer.Interval;
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
            if(hour_tr.Value > 0)
            {
                if(flag_min == 0 || flag_min % 3600 == 0)
                {
                    hour_tr.Value--;
                    timer_label_hour.Text = hour_tr.Value.ToString();
                    minute_tr.Value = 59;
                    timer_label_minute.Text = minute_tr.Value.ToString();
                    second_tr.Value = 60;
                    timer_label_second.Text = second_tr.Value.ToString();
                }
            }
            else if(minute_tr.Value > 0)
            {
                if(flag_min == 0 || flag_min % 60 == 0)
                {
                    minute_tr.Value = m - 1;
                    timer_label_minute.Text = minute_tr.Value.ToString();
                    m--;
                    second_tr.Value = 60;
                    timer_label_second.Text = second_tr.Value.ToString();
                }
            }
            //if (flag_min > 0 && flag_min % 1 == 0)
            //{
            second_tr.Value--;
            timer_label_second.Text = second_tr.Value.ToString();
            //}
            if(m > 0 && flag_min > 0 && flag_min % 60 == 0)
            {
                minute_tr.Value--;
                timer_label_minute.Text = minute_tr.Value.ToString();
            }
            if(i == flag_min) timer.Stop();
            flag_min++;
        }
    }
}
