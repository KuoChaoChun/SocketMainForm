namespace SocketMainForm
{
    partial class SocketMainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResultTxt = new System.Windows.Forms.TextBox();
            this.SavePathTxt = new System.Windows.Forms.TextBox();
            this.SetFileNameTxt = new System.Windows.Forms.TextBox();
            this.SetPortTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RequestBtn = new System.Windows.Forms.Button();
            this.SetIpTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GetFileNameTxt = new System.Windows.Forms.TextBox();
            this.GetPortTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GetIpTxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResultTxt);
            this.groupBox1.Controls.Add(this.SavePathTxt);
            this.groupBox1.Controls.Add(this.SetFileNameTxt);
            this.groupBox1.Controls.Add(this.SetPortTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RequestBtn);
            this.groupBox1.Controls.Add(this.SetIpTxt);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 446);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // ResultTxt
            // 
            this.ResultTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultTxt.Enabled = false;
            this.ResultTxt.Font = new System.Drawing.Font("Consolas", 12F);
            this.ResultTxt.Location = new System.Drawing.Point(22, 247);
            this.ResultTxt.Multiline = true;
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.Size = new System.Drawing.Size(383, 140);
            this.ResultTxt.TabIndex = 14;
            this.ResultTxt.Text = "123";
            // 
            // SavePathTxt
            // 
            this.SavePathTxt.Font = new System.Drawing.Font("Consolas", 12F);
            this.SavePathTxt.Location = new System.Drawing.Point(183, 176);
            this.SavePathTxt.Name = "SavePathTxt";
            this.SavePathTxt.Size = new System.Drawing.Size(222, 31);
            this.SavePathTxt.TabIndex = 13;
            // 
            // SetFileNameTxt
            // 
            this.SetFileNameTxt.Font = new System.Drawing.Font("Consolas", 12F);
            this.SetFileNameTxt.Location = new System.Drawing.Point(183, 136);
            this.SetFileNameTxt.Name = "SetFileNameTxt";
            this.SetFileNameTxt.Size = new System.Drawing.Size(222, 31);
            this.SetFileNameTxt.TabIndex = 12;
            // 
            // SetPortTxt
            // 
            this.SetPortTxt.Font = new System.Drawing.Font("Consolas", 12F);
            this.SetPortTxt.Location = new System.Drawing.Point(183, 96);
            this.SetPortTxt.Name = "SetPortTxt";
            this.SetPortTxt.Size = new System.Drawing.Size(222, 31);
            this.SetPortTxt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F);
            this.label5.Location = new System.Drawing.Point(18, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Result：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F);
            this.label4.Location = new System.Drawing.Point(20, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Save Path：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.Location = new System.Drawing.Point(20, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "File Name：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Server Port：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Server Ip：";
            // 
            // RequestBtn
            // 
            this.RequestBtn.Font = new System.Drawing.Font("Consolas", 14F);
            this.RequestBtn.Location = new System.Drawing.Point(280, 397);
            this.RequestBtn.Name = "RequestBtn";
            this.RequestBtn.Size = new System.Drawing.Size(125, 41);
            this.RequestBtn.TabIndex = 5;
            this.RequestBtn.Text = "Request";
            this.RequestBtn.UseVisualStyleBackColor = true;
            this.RequestBtn.Click += new System.EventHandler(this.RequestBtn_Click);
            // 
            // SetIpTxt
            // 
            this.SetIpTxt.Font = new System.Drawing.Font("Consolas", 12F);
            this.SetIpTxt.Location = new System.Drawing.Point(183, 56);
            this.SetIpTxt.Name = "SetIpTxt";
            this.SetIpTxt.Size = new System.Drawing.Size(222, 31);
            this.SetIpTxt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GetFileNameTxt);
            this.groupBox2.Controls.Add(this.GetPortTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.GetIpTxt);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(478, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 446);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server";
            // 
            // GetFileNameTxt
            // 
            this.GetFileNameTxt.Enabled = false;
            this.GetFileNameTxt.Font = new System.Drawing.Font("Consolas", 12F);
            this.GetFileNameTxt.Location = new System.Drawing.Point(195, 136);
            this.GetFileNameTxt.Name = "GetFileNameTxt";
            this.GetFileNameTxt.Size = new System.Drawing.Size(222, 31);
            this.GetFileNameTxt.TabIndex = 18;
            // 
            // GetPortTxt
            // 
            this.GetPortTxt.Enabled = false;
            this.GetPortTxt.Font = new System.Drawing.Font("Consolas", 12F);
            this.GetPortTxt.Location = new System.Drawing.Point(195, 96);
            this.GetPortTxt.Name = "GetPortTxt";
            this.GetPortTxt.Size = new System.Drawing.Size(222, 31);
            this.GetPortTxt.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F);
            this.label6.Location = new System.Drawing.Point(33, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "File Name：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F);
            this.label7.Location = new System.Drawing.Point(33, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Client Port：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F);
            this.label8.Location = new System.Drawing.Point(33, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "Client Ip：";
            // 
            // GetIpTxt
            // 
            this.GetIpTxt.Enabled = false;
            this.GetIpTxt.Font = new System.Drawing.Font("Consolas", 12F);
            this.GetIpTxt.Location = new System.Drawing.Point(195, 56);
            this.GetIpTxt.Name = "GetIpTxt";
            this.GetIpTxt.Size = new System.Drawing.Size(222, 31);
            this.GetIpTxt.TabIndex = 13;
            // 
            // SocketMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 487);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SocketMainForm";
            this.Text = "SocketMainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RequestBtn;
        private System.Windows.Forms.TextBox SetIpTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SavePathTxt;
        private System.Windows.Forms.TextBox SetFileNameTxt;
        private System.Windows.Forms.TextBox SetPortTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ResultTxt;
        private System.Windows.Forms.TextBox GetFileNameTxt;
        private System.Windows.Forms.TextBox GetPortTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GetIpTxt;
    }
}

