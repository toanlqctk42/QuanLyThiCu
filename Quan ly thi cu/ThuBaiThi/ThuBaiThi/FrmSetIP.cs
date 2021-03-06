using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ThuBaiThi
{
    public partial class FrmSetIP : Form
    {
        public string FirstIP { get; set; }
        public string LastIP { get; set; }
        public string SubnetMask { get; set; }

        public FrmSetIP()
        {
            InitializeComponent();
        }


        private void cmdSubmit_Click(object sender, EventArgs e)
        {
            if (this.txtIP.Text.IndexOf('-') == -1)
                MessageBox.Show("Địa chỉ IP không hợp lệ");
            else
            {
                string[] arrayIP = this.txtIP.Text.Split('-');
                FirstIP = arrayIP[0].Trim();
                LastIP = arrayIP[1].Trim();
                SubnetMask = this.txtSubnetMask.Text.Trim();
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}