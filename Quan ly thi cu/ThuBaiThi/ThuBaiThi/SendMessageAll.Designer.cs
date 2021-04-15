
namespace ThuBaiThi
{
    partial class SendMessageAll
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lboxHistoryMessage = new System.Windows.Forms.ListBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 230);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(310, 62);
            this.txtMessage.TabIndex = 0;
            // 
            // lboxHistoryMessage
            // 
            this.lboxHistoryMessage.FormattingEnabled = true;
            this.lboxHistoryMessage.Location = new System.Drawing.Point(12, 12);
            this.lboxHistoryMessage.Name = "lboxHistoryMessage";
            this.lboxHistoryMessage.Size = new System.Drawing.Size(310, 212);
            this.lboxHistoryMessage.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(349, 230);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(95, 60);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // SendMessageAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 301);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lboxHistoryMessage);
            this.Controls.Add(this.txtMessage);
            this.Name = "SendMessageAll";
            this.Text = "SendMessageAll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.ListBox lboxHistoryMessage;
        private System.Windows.Forms.Button btnSend;
    }
}