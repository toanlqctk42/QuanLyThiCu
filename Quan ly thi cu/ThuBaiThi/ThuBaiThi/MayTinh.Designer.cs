namespace MayTinh
{
    partial class frmmaytinh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbPCname = new System.Windows.Forms.Label();
            this.lbmssv = new System.Windows.Forms.Label();
            this.lbIPclient = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPCname
            // 
            this.lbPCname.AllowDrop = true;
            this.lbPCname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPCname.AutoSize = true;
            this.lbPCname.Location = new System.Drawing.Point(27, 39);
            this.lbPCname.Name = "lbPCname";
            this.lbPCname.Size = new System.Drawing.Size(27, 13);
            this.lbPCname.TabIndex = 1;
            this.lbPCname.Text = "N/A";
            this.lbPCname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbmssv
            // 
            this.lbmssv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbmssv.AutoSize = true;
            this.lbmssv.Location = new System.Drawing.Point(27, 100);
            this.lbmssv.Name = "lbmssv";
            this.lbmssv.Size = new System.Drawing.Size(27, 13);
            this.lbmssv.TabIndex = 1;
            this.lbmssv.Text = "N/A";
            this.lbmssv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIPclient
            // 
            this.lbIPclient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbIPclient.AutoSize = true;
            this.lbIPclient.Location = new System.Drawing.Point(27, 124);
            this.lbIPclient.Name = "lbIPclient";
            this.lbIPclient.Size = new System.Drawing.Size(27, 13);
            this.lbIPclient.TabIndex = 1;
            this.lbIPclient.Text = "N/A";
            this.lbIPclient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 7000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 97);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmmaytinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbIPclient);
            this.Controls.Add(this.lbmssv);
            this.Controls.Add(this.lbPCname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmmaytinh";
            this.Size = new System.Drawing.Size(103, 146);
            this.Load += new System.EventHandler(this.MayTinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPCname;
        private System.Windows.Forms.Label lbmssv;
        private System.Windows.Forms.Label lbIPclient;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
