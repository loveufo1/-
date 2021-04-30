namespace 會計
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.B_Out = new System.Windows.Forms.Button();
            this.B_In = new System.Windows.Forms.Button();
            this.B_InandOut = new System.Windows.Forms.Button();
            this.B_Client = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.B_Out);
            this.splitContainer1.Panel2.Controls.Add(this.B_In);
            this.splitContainer1.Panel2.Controls.Add(this.B_InandOut);
            this.splitContainer1.Panel2.Controls.Add(this.B_Client);
            this.splitContainer1.Size = new System.Drawing.Size(938, 547);
            this.splitContainer1.SplitterDistance = 764;
            this.splitContainer1.TabIndex = 0;
            // 
            // B_Out
            // 
            this.B_Out.Location = new System.Drawing.Point(27, 235);
            this.B_Out.Name = "B_Out";
            this.B_Out.Size = new System.Drawing.Size(114, 36);
            this.B_Out.TabIndex = 3;
            this.B_Out.Text = "應付帳款";
            this.B_Out.UseVisualStyleBackColor = true;
            this.B_Out.Click += new System.EventHandler(this.B_Out_Click);
            // 
            // B_In
            // 
            this.B_In.Location = new System.Drawing.Point(30, 166);
            this.B_In.Name = "B_In";
            this.B_In.Size = new System.Drawing.Size(109, 38);
            this.B_In.TabIndex = 2;
            this.B_In.Text = "應收帳款";
            this.B_In.UseVisualStyleBackColor = true;
            // 
            // B_InandOut
            // 
            this.B_InandOut.Location = new System.Drawing.Point(27, 100);
            this.B_InandOut.Name = "B_InandOut";
            this.B_InandOut.Size = new System.Drawing.Size(113, 36);
            this.B_InandOut.TabIndex = 1;
            this.B_InandOut.Text = "庫存管理";
            this.B_InandOut.UseVisualStyleBackColor = true;
            this.B_InandOut.Click += new System.EventHandler(this.B_InandOut_Click);
            // 
            // B_Client
            // 
            this.B_Client.Location = new System.Drawing.Point(27, 26);
            this.B_Client.Name = "B_Client";
            this.B_Client.Size = new System.Drawing.Size(114, 43);
            this.B_Client.TabIndex = 0;
            this.B_Client.Text = "客戶資料管理";
            this.B_Client.UseVisualStyleBackColor = true;
            this.B_Client.Click += new System.EventHandler(this.B_Client_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 547);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button B_Out;
        private System.Windows.Forms.Button B_In;
        private System.Windows.Forms.Button B_InandOut;
        private System.Windows.Forms.Button B_Client;
    }
}

