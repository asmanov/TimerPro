using System.Drawing;
using System.Windows.Forms;

namespace Timer_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Text = "Form1";
            this.BackColor = System.Drawing.Color.FromArgb(255, 0,120, 255);

            TR_box = new GroupBox();
            TR_box.Location = new Point(10,10);
            TR_box.Width = 430;
           

            #region TrackBar Group

            hour_tr = new TrackBar();
            hour_tr.Width = 300;
            hour_tr.BackColor = Color.FromArgb(255, 255, 255, 102);
            hour_tr.Minimum = 0;
            hour_tr.Maximum = 23;
            hour_tr.Location = new Point(10, 10);
            minute_tr = new TrackBar();
            minute_tr.Location = new Point(10, hour_tr.Location.Y + hour_tr.Height + 10);
            minute_tr.BackColor = Color.FromArgb(255, 255, 255, 102);
            minute_tr.Minimum = 0;
            minute_tr.Maximum = 59;
            minute_tr.Width = 300;
            second_tr = new TrackBar();
            second_tr.Location = new Point(10, minute_tr.Location.Y + minute_tr.Height + 10);
            second_tr.BackColor = Color.FromArgb(255, 255, 255, 102);
            second_tr.Minimum = 0;
            second_tr.Maximum = 59;
            second_tr.Width = 300;
            #endregion

            TR_box.Height = hour_tr.Height + minute_tr.Height + second_tr.Height + 40;
            start_btn = new Button();
            start_btn.Size = new Size(200, 100);
            start_btn.Text = "START";
            start_btn.BackColor = Color.FromArgb(200, 255, 0, 80);

            start_btn.Location =new Point(this.Width/2 - start_btn.Width/2, TR_box.Location.Y + TR_box.Height+30);

            TR_label = new GroupBox();
            TR_label.Location = new Point(10, start_btn.Location.Y + start_btn.Height + 30);
            TR_label.Width = 430;


            this.Controls.Add(TR_label);
            this.Controls.Add(TR_box);
            TR_box.Controls.Add(hour_tr);
            TR_box.Controls.Add(minute_tr);
            TR_box.Controls.Add(second_tr);
            this.Controls.Add(start_btn);

        }
        GroupBox TR_box;
        GroupBox TR_label;
        Button start_btn;
        TrackBar hour_tr;
        TrackBar minute_tr;
        TrackBar second_tr;
        #endregion
    }
}

