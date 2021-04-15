using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NetLib;

namespace ThuBaiThi
{
    public partial class SendMessageAll : Form
    {
        public Action<string> clicksend;
        public SendMessageAll()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            clicksend(txtMessage.Text);
            lboxHistoryMessage.Items.Add(txtMessage.Text);
            txtMessage.Text = "";
            
        }
    }
}
