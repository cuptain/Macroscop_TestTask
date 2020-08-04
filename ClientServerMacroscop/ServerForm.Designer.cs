namespace ServerMacroscop
{
    partial class ServerForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbN = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.lblLog = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(27, 9);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 13);
            this.lblIP.TabIndex = 2;
            this.lblIP.Text = "IP:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(12, 32);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Порт:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(53, 29);
            this.tbPort.MaxLength = 5;
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(148, 20);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "7000";
            this.tbPort.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPort_KeyPress);
            // 
            // tbN
            // 
            this.tbN.Location = new System.Drawing.Point(164, 55);
            this.tbN.MaxLength = 2;
            this.tbN.Name = "tbN";
            this.tbN.Size = new System.Drawing.Size(37, 20);
            this.tbN.TabIndex = 4;
            this.tbN.Text = "20";
            this.tbN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbN_KeyPress);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(53, 6);
            this.tbIP.MaxLength = 15;
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(148, 20);
            this.tbIP.TabIndex = 2;
            this.tbIP.Text = "127.0.0.1";
            this.tbIP.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIP_KeyPress);
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(12, 52);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(149, 26);
            this.lblN.TabIndex = 7;
            this.lblN.Text = "Количество одновременно \r\nобрабатываемых запросов:";
            this.lblN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 84);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(53, 13);
            this.lblLog.TabIndex = 9;
            this.lblLog.Text = "Консоль:";
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Image = global::ServerMacroscop.Properties.Resources.forbidden;
            this.btnStop.Location = new System.Drawing.Point(208, 52);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 40);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Image = global::ServerMacroscop.Properties.Resources.power__3_;
            this.btnStart.Location = new System.Drawing.Point(208, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(40, 40);
            this.btnStart.TabIndex = 0;
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbLog
            // 
            this.tbLog.DetectUrls = false;
            this.tbLog.HideSelection = false;
            this.tbLog.Location = new System.Drawing.Point(15, 100);
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(233, 174);
            this.tbLog.TabIndex = 10;
            this.tbLog.Text = "";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 285);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tbN);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сервер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbN;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblLog;
        public System.Windows.Forms.RichTextBox tbLog;
    }
}

