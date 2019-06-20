namespace TCP_IP_Client
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.labelTrueFalse = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.connection = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(124, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 20);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "localhost";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(124, 38);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(100, 20);
            this.txtPort.TabIndex = 2;
            this.txtPort.Text = "21";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(33, 15);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(51, 13);
            this.labelIP.TabIndex = 3;
            this.labelIP.Text = "Server IP";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(33, 41);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(60, 13);
            this.labelPort.TabIndex = 4;
            this.labelPort.Text = "Server Port";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(124, 64);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(44, 129);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(40, 23);
            this.btnStatus.TabIndex = 6;
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(121, 134);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(49, 13);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Waiting..";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(36, 176);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(188, 146);
            this.txtMessage.TabIndex = 8;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(124, 341);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.TabIndex = 9;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // labelTrueFalse
            // 
            this.labelTrueFalse.AutoSize = true;
            this.labelTrueFalse.Location = new System.Drawing.Point(121, 160);
            this.labelTrueFalse.Name = "labelTrueFalse";
            this.labelTrueFalse.Size = new System.Drawing.Size(0, 13);
            this.labelTrueFalse.TabIndex = 10;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(124, 93);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 23);
            this.btnDisconnect.TabIndex = 11;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 376);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.labelTrueFalse);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelIP);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtIP);
            this.Name = "Form1";
            this.Text = "TCP/IP Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label labelTrueFalse;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Timer connection;
    }
}

