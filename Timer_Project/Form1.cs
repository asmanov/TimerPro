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
        private int I = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, System.EventArgs e)
        {
            h = 36000 * hour_tr.Value;
            m = 600 * minute_tr.Value;
            s = 10 * second_tr.Value;
            timer.Interval = h + m + s;
            timer.Start();
            timer_label_second.Text = second_tr.Value.ToString();
            timer_label_minute.Text = minute_tr.Value.ToString();
            timer_label_hour.Text = hour_tr.Value.ToString();
            I = timer.Interval;
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
            if (I % 10 == 0 && second_tr.Value > 0) 
            { 
                --(second_tr.Value);
                timer_label_second.Text = second_tr.Value.ToString();
                
            }
            if (second_tr.Value == 0 && I % 60 == 0 && minute_tr.Value > 0)
            {
                --(minute_tr.Value);
                timer_label_minute.Text = minute_tr.Value.ToString();
            }
           
            if(I == 0) timer.Stop();
            --I;
        }
    }
}
