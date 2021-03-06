using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.IO;

using NetLib;

namespace Client
{
    public partial class Client : Form
    {
        ClientPro client;
        private const int port = 1605;
        public Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            client = new ClientPro();
            client.NhanDSfileExcel += NhanDSSVExcel;
            client.Message += Message;
            client.exam += SetDeThi;
            client.MonThi += SetMonThi;
            client.ThoigianThi += SetThoiGianThi;
        }

        private void cmdKetNoi_Click(object sender, EventArgs e)
        { 
            client.Connect(txtKetNoi.Text,port);
            cmdKetNoi.Enabled = false;
        }
        void NhanDSSVExcel(List<Student> students)
        {
            cbDSThi.DataSource = students;
            cbDSThi.DisplayMember = "FullName";
        }
        void SetDeThi(string filepath)
        {
            lblDeThi.Text = filepath;
        }
        void SetMonThi(string monthi)
        {
            lblMonThi.Text = monthi;
        }
        void SetThoiGianThi(string timeexam)
        {
            lblThoiGian.Text = timeexam;
        }
        void Message(string s)
        {
            MessageBox.Show(s,"Thông báo " , MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        private void cmdChapNhan_Click(object sender, EventArgs e)
        {
            if (cbDSThi.SelectedItem == null)
                return;
            Student student = cbDSThi.SelectedItem as Student;
            lblHoTen.Text = student.FullName;
            lblMaSo.Text = student.MSSV;
            client.SendInFoStudent(student);
            cmdChapNhan.Enabled = false;
        }

        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.CloseConnection();
        }

        private void cmdNopBaiThi_Click(object sender, EventArgs e)
        {
            client.NopbaiThi();
        }
    }
}