namespace SocketClient
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_message = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.rch_back = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv_client = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "连接服务器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "隐身";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(194, 301);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "发送消息";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(13, 300);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(160, 21);
            this.txt_message.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ip";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(73, 7);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(102, 21);
            this.txt_ip.TabIndex = 4;
            this.txt_ip.Text = "192.168.70.99";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(73, 34);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(102, 21);
            this.txt_port.TabIndex = 4;
            this.txt_port.Text = "3000";
            // 
            // rch_back
            // 
            this.rch_back.Location = new System.Drawing.Point(13, 92);
            this.rch_back.Name = "rch_back";
            this.rch_back.Size = new System.Drawing.Size(256, 193);
            this.rch_back.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "昵称";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(75, 61);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 21);
            this.txt_name.TabIndex = 7;
            this.txt_name.Text = "小红";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_name);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.rch_back);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.txt_port);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txt_ip);
            this.splitContainer1.Panel1.Controls.Add(this.txt_message);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_client);
            this.splitContainer1.Size = new System.Drawing.Size(512, 332);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.TabIndex = 8;
            // 
            // dgv_client
            // 
            this.dgv_client.AllowUserToAddRows = false;
            this.dgv_client.AllowUserToDeleteRows = false;
            this.dgv_client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_client.Location = new System.Drawing.Point(0, 0);
            this.dgv_client.Name = "dgv_client";
            this.dgv_client.ReadOnly = true;
            this.dgv_client.RowHeadersWidth = 10;
            this.dgv_client.RowTemplate.Height = 23;
            this.dgv_client.Size = new System.Drawing.Size(222, 332);
            this.dgv_client.TabIndex = 0;
            this.dgv_client.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_friend_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Client";
            this.Column1.HeaderText = "好友";
            this.Column1.MinimumWidth = 200;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 332);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Clicent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_client)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txt_message;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.RichTextBox rch_back;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgv_client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

