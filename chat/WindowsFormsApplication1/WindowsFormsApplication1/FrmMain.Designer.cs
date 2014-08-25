namespace WindowsFormsApplication1
{
    partial class 聊天
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSend = new System.Windows.Forms.Button();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtHistory = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(268, 292);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(75, 23);
            this.txtSend.TabIndex = 0;
            this.txtSend.Text = "send";
            this.txtSend.UseVisualStyleBackColor = true;
            this.txtSend.Click += new System.EventHandler(this.txtSend_Click);
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(57, 12);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(286, 21);
            this.txtIp.TabIndex = 1;
            this.txtIp.Text = "255.255.255.255";
            this.txtIp.TextChanged += new System.EventHandler(this.txtIp_TextChanged);
            // 
            // txtHistory
            // 
            this.txtHistory.Location = new System.Drawing.Point(57, 65);
            this.txtHistory.Multiline = true;
            this.txtHistory.Name = "txtHistory";
            this.txtHistory.ReadOnly = true;
            this.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtHistory.Size = new System.Drawing.Size(286, 181);
            this.txtHistory.TabIndex = 2;
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(57, 292);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(205, 21);
            this.txtMsg.TabIndex = 3;
            this.txtMsg.TextChanged += new System.EventHandler(this.txtMsg_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(454, 10);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 303);
            this.textBox1.TabIndex = 4;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(349, 292);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 5;
            this.exit.Text = "退出";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // 聊天
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 369);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtHistory);
            this.Controls.Add(this.txtIp);
            this.Controls.Add(this.txtSend);
            this.Name = "聊天";
            this.Text = "聊天";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtSend;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtHistory;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button exit;
    }
}

