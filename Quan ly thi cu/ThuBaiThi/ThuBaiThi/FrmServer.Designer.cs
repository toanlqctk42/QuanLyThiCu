namespace ThuBaiThi
{
    partial class FrmServer
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
            this.lstDeThi = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdphatde = new System.Windows.Forms.Button();
            this.cmdXoaDethi = new System.Windows.Forms.Button();
            this.cmdThemdethi = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdThuBai = new System.Windows.Forms.Button();
            this.rbLuuserver = new System.Windows.Forms.RadioButton();
            this.rbLuuClient = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdChonClientPath = new System.Windows.Forms.Button();
            this.cmdChon = new System.Windows.Forms.Button();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.flpPc = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMonThi = new System.Windows.Forms.TextBox();
            this.txtThoiGianLamBai = new System.Windows.Forms.TextBox();
            this.cmdDisconnect = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmdChapNhan = new System.Windows.Forms.Button();
            this.cmdSendAllMessage = new System.Windows.Forms.Button();
            this.cmdlaydsthitufile = new System.Windows.Forms.Button();
            this.cmdLaydstuCSDL = new System.Windows.Forms.Button();
            this.cmdDisableUndefine = new System.Windows.Forms.Button();
            this.cmdBatDauLamBai = new System.Windows.Forms.Button();
            this.cmdKichHoatAllClient = new System.Windows.Forms.Button();
            this.cmdNhapVungIP = new System.Windows.Forms.Button();
            this.grpfuntion = new System.Windows.Forms.GroupBox();
            this.cmdDiemDanh = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.MainGroupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.grpfuntion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstDeThi
            // 
            this.lstDeThi.FormattingEnabled = true;
            this.lstDeThi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstDeThi.Location = new System.Drawing.Point(7, 19);
            this.lstDeThi.Name = "lstDeThi";
            this.lstDeThi.Size = new System.Drawing.Size(240, 108);
            this.lstDeThi.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdphatde);
            this.groupBox1.Controls.Add(this.cmdXoaDethi);
            this.groupBox1.Controls.Add(this.cmdThemdethi);
            this.groupBox1.Controls.Add(this.lstDeThi);
            this.groupBox1.Location = new System.Drawing.Point(248, 496);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 153);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Đề Thi";
            // 
            // cmdphatde
            // 
            this.cmdphatde.Location = new System.Drawing.Point(253, 95);
            this.cmdphatde.Name = "cmdphatde";
            this.cmdphatde.Size = new System.Drawing.Size(88, 32);
            this.cmdphatde.TabIndex = 33;
            this.cmdphatde.Text = "Phát Đề";
            this.cmdphatde.UseVisualStyleBackColor = true;
            this.cmdphatde.Click += new System.EventHandler(this.cmdphatde_Click);
            // 
            // cmdXoaDethi
            // 
            this.cmdXoaDethi.Location = new System.Drawing.Point(253, 60);
            this.cmdXoaDethi.Name = "cmdXoaDethi";
            this.cmdXoaDethi.Size = new System.Drawing.Size(88, 29);
            this.cmdXoaDethi.TabIndex = 32;
            this.cmdXoaDethi.Text = "Xoá Đề Thi";
            this.cmdXoaDethi.UseVisualStyleBackColor = true;
            this.cmdXoaDethi.Click += new System.EventHandler(this.cmdXoaDethi_Click);
            // 
            // cmdThemdethi
            // 
            this.cmdThemdethi.Location = new System.Drawing.Point(253, 24);
            this.cmdThemdethi.Name = "cmdThemdethi";
            this.cmdThemdethi.Size = new System.Drawing.Size(88, 29);
            this.cmdThemdethi.TabIndex = 31;
            this.cmdThemdethi.Text = "Thêm Đề Thi";
            this.cmdThemdethi.UseVisualStyleBackColor = true;
            this.cmdThemdethi.Click += new System.EventHandler(this.cmdThemdethi_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdThuBai);
            this.groupBox2.Controls.Add(this.rbLuuserver);
            this.groupBox2.Controls.Add(this.rbLuuClient);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(872, 496);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 150);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Noi Lưu Bài Thi";
            // 
            // cmdThuBai
            // 
            this.cmdThuBai.Location = new System.Drawing.Point(10, 104);
            this.cmdThuBai.Name = "cmdThuBai";
            this.cmdThuBai.Size = new System.Drawing.Size(99, 23);
            this.cmdThuBai.TabIndex = 2;
            this.cmdThuBai.Text = "Thu Bài";
            this.cmdThuBai.UseVisualStyleBackColor = true;
            this.cmdThuBai.Click += new System.EventHandler(this.cmdThuBai_Click);
            // 
            // rbLuuserver
            // 
            this.rbLuuserver.AutoSize = true;
            this.rbLuuserver.Location = new System.Drawing.Point(10, 74);
            this.rbLuuserver.Name = "rbLuuserver";
            this.rbLuuserver.Size = new System.Drawing.Size(56, 17);
            this.rbLuuserver.TabIndex = 1;
            this.rbLuuserver.TabStop = true;
            this.rbLuuserver.Text = "Server";
            this.rbLuuserver.UseVisualStyleBackColor = true;
            // 
            // rbLuuClient
            // 
            this.rbLuuClient.AutoSize = true;
            this.rbLuuClient.Checked = true;
            this.rbLuuClient.Location = new System.Drawing.Point(10, 51);
            this.rbLuuClient.Name = "rbLuuClient";
            this.rbLuuClient.Size = new System.Drawing.Size(51, 17);
            this.rbLuuClient.TabIndex = 1;
            this.rbLuuClient.TabStop = true;
            this.rbLuuClient.Text = "Client";
            this.rbLuuClient.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài thi được lưu ở";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Server Path:";
            // 
            // txtServerPath
            // 
            this.txtServerPath.Location = new System.Drawing.Point(12, 36);
            this.txtServerPath.Name = "txtServerPath";
            this.txtServerPath.Size = new System.Drawing.Size(120, 20);
            this.txtServerPath.TabIndex = 34;
            this.txtServerPath.Text = "C:\\serverPath";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Client Path:";
            // 
            // txtClientPath
            // 
            this.txtClientPath.Location = new System.Drawing.Point(12, 82);
            this.txtClientPath.Name = "txtClientPath";
            this.txtClientPath.Size = new System.Drawing.Size(120, 20);
            this.txtClientPath.TabIndex = 34;
            this.txtClientPath.Text = "C:\\tam";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdChonClientPath);
            this.groupBox3.Controls.Add(this.cmdChon);
            this.groupBox3.Controls.Add(this.txtClientPath);
            this.groupBox3.Controls.Add(this.txtServerPath);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(14, 493);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 156);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn Đường Dẫn";
            // 
            // cmdChonClientPath
            // 
            this.cmdChonClientPath.Location = new System.Drawing.Point(139, 80);
            this.cmdChonClientPath.Name = "cmdChonClientPath";
            this.cmdChonClientPath.Size = new System.Drawing.Size(62, 23);
            this.cmdChonClientPath.TabIndex = 36;
            this.cmdChonClientPath.Text = "Chọn";
            this.cmdChonClientPath.UseVisualStyleBackColor = true;
            this.cmdChonClientPath.Click += new System.EventHandler(this.cmdChonClientPath_Click);
            // 
            // cmdChon
            // 
            this.cmdChon.Location = new System.Drawing.Point(139, 36);
            this.cmdChon.Name = "cmdChon";
            this.cmdChon.Size = new System.Drawing.Size(62, 24);
            this.cmdChon.TabIndex = 35;
            this.cmdChon.Text = "Chọn";
            this.cmdChon.UseVisualStyleBackColor = true;
            this.cmdChon.Click += new System.EventHandler(this.cmdChon_Click);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGroupBox.AutoSize = true;
            this.MainGroupBox.Controls.Add(this.flpPc);
            this.MainGroupBox.Location = new System.Drawing.Point(138, 12);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(866, 473);
            this.MainGroupBox.TabIndex = 37;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "Danh Sách Các Máy Tính Trong Phòng Máy";
            // 
            // flpPc
            // 
            this.flpPc.AutoScroll = true;
            this.flpPc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPc.Location = new System.Drawing.Point(3, 16);
            this.flpPc.Name = "flpPc";
            this.flpPc.Size = new System.Drawing.Size(860, 454);
            this.flpPc.TabIndex = 2;
            // 
            // txtMonThi
            // 
            this.txtMonThi.Location = new System.Drawing.Point(11, 21);
            this.txtMonThi.Name = "txtMonThi";
            this.txtMonThi.Size = new System.Drawing.Size(203, 20);
            this.txtMonThi.TabIndex = 28;
            this.txtMonThi.Text = "Chọn Môn Thi";
            this.txtMonThi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtThoiGianLamBai
            // 
            this.txtThoiGianLamBai.Location = new System.Drawing.Point(11, 60);
            this.txtThoiGianLamBai.Name = "txtThoiGianLamBai";
            this.txtThoiGianLamBai.Size = new System.Drawing.Size(203, 20);
            this.txtThoiGianLamBai.TabIndex = 28;
            this.txtThoiGianLamBai.Text = "120";
            this.txtThoiGianLamBai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdDisconnect
            // 
            this.cmdDisconnect.Location = new System.Drawing.Point(7, 57);
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.Size = new System.Drawing.Size(109, 30);
            this.cmdDisconnect.TabIndex = 40;
            this.cmdDisconnect.Text = "Disconnect";
            this.cmdDisconnect.UseVisualStyleBackColor = true;
            this.cmdDisconnect.Click += new System.EventHandler(this.cmdDisconnect_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmdChapNhan);
            this.groupBox5.Controls.Add(this.txtThoiGianLamBai);
            this.groupBox5.Controls.Add(this.txtMonThi);
            this.groupBox5.Location = new System.Drawing.Point(608, 496);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(239, 150);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chọn Môn Thi và Thời Gian Làm Bài";
            // 
            // cmdChapNhan
            // 
            this.cmdChapNhan.Location = new System.Drawing.Point(65, 104);
            this.cmdChapNhan.Name = "cmdChapNhan";
            this.cmdChapNhan.Size = new System.Drawing.Size(103, 23);
            this.cmdChapNhan.TabIndex = 29;
            this.cmdChapNhan.Text = "Chấp Nhận";
            this.cmdChapNhan.UseVisualStyleBackColor = true;
            this.cmdChapNhan.Click += new System.EventHandler(this.cmdChapNhan_Click);
            // 
            // cmdSendAllMessage
            // 
            this.cmdSendAllMessage.Location = new System.Drawing.Point(7, 94);
            this.cmdSendAllMessage.Name = "cmdSendAllMessage";
            this.cmdSendAllMessage.Size = new System.Drawing.Size(109, 40);
            this.cmdSendAllMessage.TabIndex = 40;
            this.cmdSendAllMessage.Text = "Send Message To All";
            this.cmdSendAllMessage.UseVisualStyleBackColor = true;
            this.cmdSendAllMessage.Click += new System.EventHandler(this.cmdSendAllMessage_Click);
            // 
            // cmdlaydsthitufile
            // 
            this.cmdlaydsthitufile.Location = new System.Drawing.Point(7, 139);
            this.cmdlaydsthitufile.Name = "cmdlaydsthitufile";
            this.cmdlaydsthitufile.Size = new System.Drawing.Size(109, 43);
            this.cmdlaydsthitufile.TabIndex = 40;
            this.cmdlaydsthitufile.Text = "Lấy Danh Sách Thi Từ File";
            this.cmdlaydsthitufile.UseVisualStyleBackColor = true;
            this.cmdlaydsthitufile.Click += new System.EventHandler(this.cmdlaydsthitufile_Click);
            // 
            // cmdLaydstuCSDL
            // 
            this.cmdLaydstuCSDL.Location = new System.Drawing.Point(7, 189);
            this.cmdLaydstuCSDL.Name = "cmdLaydstuCSDL";
            this.cmdLaydstuCSDL.Size = new System.Drawing.Size(109, 43);
            this.cmdLaydstuCSDL.TabIndex = 40;
            this.cmdLaydstuCSDL.Text = "Lấy Danh Sách Thi Từ CSDL";
            this.cmdLaydstuCSDL.UseVisualStyleBackColor = true;
            this.cmdLaydstuCSDL.Click += new System.EventHandler(this.cmdLaydstuCSDL_Click);
            // 
            // cmdDisableUndefine
            // 
            this.cmdDisableUndefine.Location = new System.Drawing.Point(7, 274);
            this.cmdDisableUndefine.Name = "cmdDisableUndefine";
            this.cmdDisableUndefine.Size = new System.Drawing.Size(109, 43);
            this.cmdDisableUndefine.TabIndex = 40;
            this.cmdDisableUndefine.Text = "Disable Tất Cả Các Máy Trống";
            this.cmdDisableUndefine.UseVisualStyleBackColor = true;
            this.cmdDisableUndefine.Click += new System.EventHandler(this.cmdDisableUndefine_Click);
            // 
            // cmdBatDauLamBai
            // 
            this.cmdBatDauLamBai.Location = new System.Drawing.Point(7, 371);
            this.cmdBatDauLamBai.Name = "cmdBatDauLamBai";
            this.cmdBatDauLamBai.Size = new System.Drawing.Size(109, 32);
            this.cmdBatDauLamBai.TabIndex = 44;
            this.cmdBatDauLamBai.Text = "Bắt Đầu Làm Bài";
            this.cmdBatDauLamBai.UseVisualStyleBackColor = true;
            this.cmdBatDauLamBai.Click += new System.EventHandler(this.cmdBatDauLamBai_Click);
            // 
            // cmdKichHoatAllClient
            // 
            this.cmdKichHoatAllClient.Location = new System.Drawing.Point(7, 324);
            this.cmdKichHoatAllClient.Name = "cmdKichHoatAllClient";
            this.cmdKichHoatAllClient.Size = new System.Drawing.Size(109, 39);
            this.cmdKichHoatAllClient.TabIndex = 45;
            this.cmdKichHoatAllClient.Text = "Kích Hoạt Tất Cả Client";
            this.cmdKichHoatAllClient.UseVisualStyleBackColor = true;
            this.cmdKichHoatAllClient.Click += new System.EventHandler(this.cmdKichHoatAllClient_Click);
            // 
            // cmdNhapVungIP
            // 
            this.cmdNhapVungIP.Location = new System.Drawing.Point(7, 21);
            this.cmdNhapVungIP.Name = "cmdNhapVungIP";
            this.cmdNhapVungIP.Size = new System.Drawing.Size(109, 30);
            this.cmdNhapVungIP.TabIndex = 46;
            this.cmdNhapVungIP.Text = "Nhập Vùng  IP";
            this.cmdNhapVungIP.UseVisualStyleBackColor = true;
            this.cmdNhapVungIP.Click += new System.EventHandler(this.cmdNhapVungIP_Click);
            // 
            // grpfuntion
            // 
            this.grpfuntion.Controls.Add(this.cmdDiemDanh);
            this.grpfuntion.Controls.Add(this.lblTimer);
            this.grpfuntion.Controls.Add(this.cmdNhapVungIP);
            this.grpfuntion.Controls.Add(this.cmdKichHoatAllClient);
            this.grpfuntion.Controls.Add(this.cmdBatDauLamBai);
            this.grpfuntion.Controls.Add(this.cmdSendAllMessage);
            this.grpfuntion.Controls.Add(this.cmdDisableUndefine);
            this.grpfuntion.Controls.Add(this.cmdLaydstuCSDL);
            this.grpfuntion.Controls.Add(this.cmdlaydsthitufile);
            this.grpfuntion.Controls.Add(this.cmdDisconnect);
            this.grpfuntion.Location = new System.Drawing.Point(6, 12);
            this.grpfuntion.Name = "grpfuntion";
            this.grpfuntion.Size = new System.Drawing.Size(129, 473);
            this.grpfuntion.TabIndex = 47;
            this.grpfuntion.TabStop = false;
            this.grpfuntion.Text = "Chức Năng";
            // 
            // cmdDiemDanh
            // 
            this.cmdDiemDanh.Location = new System.Drawing.Point(7, 238);
            this.cmdDiemDanh.Name = "cmdDiemDanh";
            this.cmdDiemDanh.Size = new System.Drawing.Size(109, 30);
            this.cmdDiemDanh.TabIndex = 0;
            this.cmdDiemDanh.Text = "Điểm danh";
            this.cmdDiemDanh.UseVisualStyleBackColor = true;
            this.cmdDiemDanh.Click += new System.EventHandler(this.cmdDiemDanh_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(6, 424);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(103, 37);
            this.lblTimer.TabIndex = 47;
            this.lblTimer.Text = "00:00";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 653);
            this.Controls.Add(this.grpfuntion);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmServer_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.MainGroupBox.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grpfuntion.ResumeLayout(false);
            this.grpfuntion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstDeThi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbLuuserver;
        private System.Windows.Forms.RadioButton rbLuuClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.TextBox txtMonThi;
        private System.Windows.Forms.TextBox txtThoiGianLamBai;
        private System.Windows.Forms.Button cmdChon;
        private System.Windows.Forms.Button cmdThemdethi;
        private System.Windows.Forms.Button cmdDisconnect;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button cmdSendAllMessage;
        private System.Windows.Forms.Button cmdChapNhan;
        private System.Windows.Forms.Button cmdlaydsthitufile;
        private System.Windows.Forms.Button cmdLaydstuCSDL;
        private System.Windows.Forms.Button cmdDisableUndefine;
        private System.Windows.Forms.Button cmdBatDauLamBai;
        private System.Windows.Forms.Button cmdChonClientPath;
        private System.Windows.Forms.Button cmdKichHoatAllClient;
        private System.Windows.Forms.Button cmdNhapVungIP;
        private System.Windows.Forms.GroupBox grpfuntion;
        private System.Windows.Forms.FlowLayoutPanel flpPc;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cmdXoaDethi;
        private System.Windows.Forms.Button cmdThuBai;
        private System.Windows.Forms.Button cmdDiemDanh;
        private System.Windows.Forms.Button cmdphatde;
    }
}

