using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ThuBaiThi;


namespace MayTinh
{
    public partial class frmmaytinh : UserControl
    {
        public Maytinhinfo maytinhinfo { get; private set; }
        public frmmaytinh(Maytinhinfo maytinh)
        {
            InitializeComponent();
            maytinhinfo = new Maytinhinfo(maytinh);
            SetContent(maytinh);

        }

        private void MayTinh_Load(object sender, EventArgs e)
        {
            lbPCname.BorderStyle = BorderStyle.None;
            lbmssv.BorderStyle = BorderStyle.None;
            lbIPclient.BorderStyle = BorderStyle.None;
        }
        public void SetClient(Maytinhinfo client)
        {
            maytinhinfo = client;
            SetContent(client);
        }

        void SetContent(Maytinhinfo mt)
        {
            if (!string.IsNullOrWhiteSpace(mt.PCName))
                lbPCname.Text = mt.PCName;
            else
                lbPCname.Text = "N/A";

            if (!string.IsNullOrWhiteSpace(mt.student.MSSV))
                lbmssv.Text = mt.student.MSSV;
            else
                lbmssv.Text = "N/A";

            if (!string.IsNullOrWhiteSpace(mt.ClientIP))
                lbIPclient.Text = mt.ClientIP;
            else
                lbIPclient.Text = "!IP";

            string imgstatus;
            switch (mt.status)
            {
                case ClientinfoStatus.Undefine:
                    imgstatus = "destopundefine.jpg";
                    break;
                case ClientinfoStatus.ClientConnected:
                    imgstatus = "desktopnomar.jpg";
                    break;
                case ClientinfoStatus.StudentConnected:
                    imgstatus = "desktopchapnhan.jpg";
                    break;
                case ClientinfoStatus.Disconnected:
                    imgstatus = "desktoperror.jpg";
                    break;
                default:
                    imgstatus = "destopundefine.jpg";
                    break;
            }
            Bitmap bitmap = new Bitmap(NetLib.PathUtils.GetPathTo("image", imgstatus));
            pictureBox1.BackgroundImage = bitmap;/*
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;*/
        }
    }
}
