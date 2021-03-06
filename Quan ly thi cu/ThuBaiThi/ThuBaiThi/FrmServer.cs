using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MayTinh;
using NetLib;
using System.IO;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
using System.Drawing;

namespace ThuBaiThi
{
    public partial class FrmServer : Form
    {

        ServerThread serverThread;
        /*Thread t, CommandProcessThread, threadDemLuiThoiGian;
        Thread copyDir;*/

        
       

        private void Form1_Load(object sender, EventArgs e)
        {
            serverThread = new ServerThread();
            serverThread.OnClientListChanged += HandleOnClientListChanged;
            serverThread.Start();
        }

        #region It Khi dung den
        private void HandleOnClientListChanged(List<Maytinhinfo> clientList)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate ()
                {
                    RenderClientList(clientList);
                });
            }
            else
            {
                RenderClientList(clientList);
            }
        }/*
        public delegate void SetTextCallBack(string text);*/



        public FrmServer()
        {
            InitializeComponent();
        }
 


        private void cmdDisconnect_Click(object sender, EventArgs e)
        {
            serverThread.DisconnectAll();
        }

        private void cmdDisableUndefine_Click(object sender, EventArgs e)
        {

            List<Maytinhinfo> maytinh = new List<Maytinhinfo>();
            foreach (Control clientontrol in flpPc.Controls)
            {
                frmmaytinh frm = clientontrol as frmmaytinh;
                serverThread.DisconnectDisable(frm);
                maytinh.Add(frm.maytinhinfo);
            }
            RenderClientList(maytinh);
                
        }
        int m,s = 0;
        int total;
        
        private void cmdBatDauLamBai_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                m = Convert.ToInt32(txtThoiGianLamBai.Text);
                total = (m * 60) + s;
                timer1.Start();
                cmdBatDauLamBai.Text = "Reset Timer";
                serverThread.StartExam(txtThoiGianLamBai.Text);
            }
            else
            {
                total = 0;
                s = 0;
                timer1.Stop();
                lblTimer.Text = "00 : 00";
                cmdBatDauLamBai.Text = "Bắt đầu làm bài";
            }
        }

        private void cmdThemdethi_Click(object sender, EventArgs e)
        {
             
            OpenFileDialog odf = new OpenFileDialog();
            odf.Filter = "All files (*.*)|*.*|All files(*.*)|*.*";
            if (odf.ShowDialog() == DialogResult.OK)
            {
                string name = odf.FileName;
                lstDeThi.Items.Add(name);
            }
        }

        private void FrmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverThread.Close();
        }

        private void cmdChon_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folder = new FolderBrowserDialog())
            {
                DialogResult dialog = folder.ShowDialog();
                if (dialog == DialogResult.OK && !string.IsNullOrWhiteSpace(folder.SelectedPath))
                {
                    txtServerPath.Text = folder.SelectedPath;
                    serverThread.SetServerPath(folder.SelectedPath);
                }
            }
        }

        private void cmdChonClientPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folder = new FolderBrowserDialog())
            {
                DialogResult dialog = folder.ShowDialog();
                if (dialog == DialogResult.OK && !string.IsNullOrWhiteSpace(folder.SelectedPath))
                {
                    txtClientPath.Text = folder.SelectedPath;
                    serverThread.SetClientPath(folder.SelectedPath);
                }
            }
        }

        private void cmdlaydsthitufile_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "All files (*.*)|*.*|All files(*.*)|*.*";
            openFile.Multiselect = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                List<Student> dssv = DocNoiDungFileExcel(openFile.FileName);
                serverThread.SendListStudent(dssv);
            }


        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (total > 0)
            {
                total--;
                m = total / 60;
                s = total - (m * 60);
                this.lblTimer.Text = m.ToString() + " : " + s.ToString();
                if (m < 10)
                { this.lblTimer.Text = "0" + m.ToString() + " : " + s.ToString(); }
                if(s<10)
                { this.lblTimer.Text =  m.ToString() + " : "+"0" + s.ToString(); }
                if(m<10 && s<10)
                { this.lblTimer.Text = "0" + m.ToString() + " : " + "0" + s.ToString(); }
            }
            else
            {
                this.timer1.Stop();
                serverThread.Thubai();
            }
        }

        void RenderClientList(List<Maytinhinfo> clientList)
        {
            if (flpPc.Controls.Count == 0)
            {
                foreach (Maytinhinfo clientInfo in clientList)
                {
                    frmmaytinh frm = new frmmaytinh(clientInfo);
                    flpPc.Controls.Add(frm);
                }

                return;
            }

            int clientControlLength = flpPc.Controls.Count;
            int i = 0;
            for (i = 0; i < clientList.Count; i++)
            {
                Maytinhinfo clientInfoInList = clientList[i];

                if (i < clientControlLength)
                {
                    frmmaytinh frm = flpPc.Controls[i] as frmmaytinh;
                    Maytinhinfo clientInfoInControl = frm.maytinhinfo;

                    frm.SetClient(clientInfoInList);
                }
                else
                {
                    frmmaytinh frm = new frmmaytinh(clientInfoInList);
                    flpPc.Controls.Add(frm);
                }
            }

            if (i < flpPc.Controls.Count)
                for (int j = flpPc.Controls.Count - 1; j >= i; j--)
                    flpPc.Controls.RemoveAt(j);
        }
        private void cmdDiemDanh_Click(object sender, EventArgs e)
        {

            List<Student> students = new List<Student>();
            foreach  (Control control in flpPc.Controls)
            {
                frmmaytinh frm = control as frmmaytinh;
                if(frm.maytinhinfo.status == ClientinfoStatus.StudentConnected)
                {
                    students.Add(frm.maytinhinfo.student);
                }
            }
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "All files (*.*)|*.*";
            dialog.Title = "Save";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter stream = new StreamWriter(dialog.FileName);
                stream.WriteLine(students.Count);
                foreach (Student item in students)
                {
                    stream.WriteLine(item.MSSV + '\t' + item.FullName);
                }
                stream.Close();
            }
            
        }
        private void cmdNhapVungIP_Click(object sender, EventArgs e)
        {
            FrmSetIP frmSetIP = new FrmSetIP();
            DialogResult result = frmSetIP.ShowDialog();
            if (result !=DialogResult.OK)
            {
                return;
            }
            string FirstIP = frmSetIP.FirstIP;
            string LastIP = frmSetIP.LastIP;
            string SubnetMask = frmSetIP.SubnetMask;
            serverThread.SetClienttoList(FirstIP, LastIP, SubnetMask);
        }

        private void cmdXoaDethi_Click(object sender, EventArgs e)
        {
            if (lstDeThi.Items.Count != 0)
                lstDeThi.Items.RemoveAt(0);
            return;
        }

        private void cmdLaydstuCSDL_Click(object sender, EventArgs e)
        {
            List<Student> dssv = StudentDAO.Instance.GetStudents();
            serverThread.SendListStudent(dssv);
        }

        private void cmdSendAllMessage_Click(object sender, EventArgs e)
        {
            SendMessageAll frm = new SendMessageAll();
            frm.clicksend += SendMessagetoAll;
            frm.ShowDialog();
        }
        void SendMessagetoAll(string mess)
        {
            serverThread.SendmessageAll(mess);
        }
        private void cmdChapNhan_Click(object sender, EventArgs e)
        {
            serverThread.SendMonThi(txtMonThi.Text);
            serverThread.SendThoiGianThi(txtThoiGianLamBai.Text);
        }

        private void cmdThuBai_Click(object sender, EventArgs e)
        {
            serverThread.Thubai();
        }

        private void cmdphatde_Click(object sender, EventArgs e)
        {
            if (lstDeThi.Items.Count == 0)
            {
                MessageBox.Show("Hiện Đề Thi chưa có , Vui lòng chọn đề thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            List<string> listfiledsdethi = new List<string>();
            string clientpath = txtClientPath.Text;
            string serverpath = txtServerPath.Text;
            if (string.IsNullOrWhiteSpace(serverpath) && string.IsNullOrWhiteSpace(clientpath) || string.IsNullOrWhiteSpace(serverpath) || string.IsNullOrWhiteSpace(clientpath))
            {
                MessageBox.Show("Vui lòng không để trống mục đường dẫn ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (var item in lstDeThi.Items)
            {
                string filedethi = item.ToString();
                listfiledsdethi.Add(filedethi);
            }
            serverThread.SetClientPath(clientpath);
            serverThread.SetServerPath(serverpath);
            serverThread.PhatDe(listfiledsdethi);
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {

        }

        private void cmdKichHoatAllClient_Click(object sender, EventArgs e)
        {
            List<Maytinhinfo> maytinh = new List<Maytinhinfo>();
            foreach (Control clientontrol in flpPc.Controls)
            {
                frmmaytinh frm = clientontrol as frmmaytinh;
                serverThread.Undefine(frm);
                maytinh.Add(frm.maytinhinfo);
            }
            RenderClientList(maytinh);
        }

        List<Student> DocNoiDungFileExcel(string duongDanFileExcel)
        {
            // Doc file excel
            List<Student> students = new List<Student>();
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                //mở file excel
                var package = new ExcelPackage(new FileInfo(duongDanFileExcel));

                //lấy ra sheet đầu tiên để thao tác
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                //duyệt tuần tự từ dòng thứ 2 đến dòng cuối cùng của file. Lưu ý file excel bắt đầu từ số 1 không phải số 0
                for (int i = worksheet.Dimension.Start.Row + 1; i <= worksheet.Dimension.End.Row; i++)
                {
                    try
                    {
                        // biến j biểu thị cho một column trong file
                        int j = 1;

                        // lấy ra cột mã số sinh viên tương ứng giá trị tại vị trí [i, 1]. i lần đầu là 2
                        //tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                        string mssv = worksheet.Cells[i, j++].Value.ToString();

                        // lấy ra cột họ và tên đệm tương ứng giá trị tại vị trí [i, 2]. i lần đầu là 2
                        //tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                        string hoDem = worksheet.Cells[i, j++].Value.ToString();

                        // lấy ra cột tên tương ứng giá trị tại vị trí [i, 3]. i lần đầu là 2
                        //tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                        string ten = worksheet.Cells[i, j++].Value.ToString();

                        // tạo student từ dữ liệu đã lấy được 
                        Student student = new Student()
                        {
                            MSSV = mssv,
                            LastName = hoDem,
                            FirstName = ten
                        };

                        // add student vào danh sách students
                        students.Add(student);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
            catch (Exception ee)
            {

                MessageBox.Show("Error!" + ee.Message);
            }


            return students;
        }

    }
}
#endregion