using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class frmStartExam : Form
    {
        public string timer { get; set; }
        int s = 0;
        int m = 0;
        int total = 0;
        int thirty = 0;
        public frmStartExam()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (total > 0)
            {
                total--;
                m = total / 60;
                s = total - (m * 60);
                this.lbtimer.Text = m.ToString() + " : " + s.ToString();
                if (m < 10)
                { this.lbtimer.Text = "0" + m.ToString() + " : " + s.ToString(); }
                if (s < 10)
                { this.lbtimer.Text = m.ToString() + " : " + "0" + s.ToString(); }
                if (m < 10 && s < 10)
                { this.lbtimer.Text = "0" + m.ToString() + " : " + "0" + s.ToString(); }
                if (s == 0)
                {
                    thirty++;
                }
                if (thirty == 30)
                {
                    MessageBox.Show("Thời gian còn lại là : " + m.ToString() + " phút");
                    thirty = 0;
                }

                if (m.ToString() == "05" && s.ToString() == "00")
                {
                    MessageBox.Show("Còn 5 phút nữa là hết giờ , các bạn tranh thủ lưu bài");
                }
            }
            else
            {
                this.timer1.Stop();
                MessageBox.Show("Finish !!");
            }
        }

        private void frmStartExam_Load(object sender, EventArgs e)
        {
            total =Convert.ToInt32(timer)*60;
            timer1.Start();
        }
    }
}
