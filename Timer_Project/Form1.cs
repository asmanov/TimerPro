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
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_btn_Click(object sender, System.EventArgs e)
        {
            //throw new System.NotImplementedException();
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
    }
}
