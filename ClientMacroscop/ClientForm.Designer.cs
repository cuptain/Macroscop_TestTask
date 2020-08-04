namespace ClientMacroscop
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.tbDirectory = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbLog = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(12, 15);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(20, 13);
            this.lblIP.TabIndex = 2;
            this.lblIP.Text = "IP:";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(135, 15);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(35, 13);
            this.lblPort.TabIndex = 3;
            this.lblPort.Text = "Порт:";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(176, 12);
            this.tbPort.MaxLength = 5;
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(44, 20);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "7000";
            this.tbPort.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPort_KeyPress);
            // 
            // tbIP
            // 
            this.tbIP.Location = new System.Drawing.Point(38, 12);
            this.tbIP.MaxLength = 15;
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(91, 20);
            this.tbIP.TabIndex = 2;
            this.tbIP.Text = "127.0.0.1";
            this.tbIP.TextChanged += new System.EventHandler(this.tb_TextChanged);
            this.tbIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbIP_KeyPress);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 96);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(53, 13);
            this.lblLog.TabIndex = 9;
            this.lblLog.Text = "Консоль:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(226, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(106, 23);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Подключиться";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDirectory
            // 
            this.btnDirectory.Location = new System.Drawing.Point(15, 38);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(155, 23);
            this.btnDirectory.TabIndex = 11;
            this.btnDirectory.Text = "Выбрать директорию";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // tbDirectory
            // 
            this.tbDirectory.BackColor = System.Drawing.SystemColors.Window;
            this.tbDirectory.Location = new System.Drawing.Point(15, 67);
            this.tbDirectory.Name = "tbDirectory";
            this.tbDirectory.ReadOnly = true;
            this.tbDirectory.Size = new System.Drawing.Size(317, 20);
            this.tbDirectory.TabIndex = 12;
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(176, 38);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(156, 23);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Отправить";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(15, 112);
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(317, 174);
            this.tbLog.TabIndex = 14;
            this.tbLog.Text = "";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 298);
            this.Controls.Add(this.tbLog);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbDirectory);
            this.Controls.Add(this.btnDirectory);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.tbIP);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.TextBox tbDirectory;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox tbLog;
    }
}

