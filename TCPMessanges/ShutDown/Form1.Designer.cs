namespace ShutDown
{
    partial class Form1
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
            this.txbClienIp = new System.Windows.Forms.TextBox();
            this.lbClientIp = new System.Windows.Forms.Label();
            this.lbClientPort = new System.Windows.Forms.Label();
            this.lbServertPort = new System.Windows.Forms.Label();
            this.lbServertIp = new System.Windows.Forms.Label();
            this.btnCreateClient = new System.Windows.Forms.Button();
            this.btnCreateServer = new System.Windows.Forms.Button();
            this.txbServerPort = new System.Windows.Forms.TextBox();
            this.txbClientPort = new System.Windows.Forms.TextBox();
            this.txbServerIp = new System.Windows.Forms.TextBox();
            this.listText = new System.Windows.Forms.ListBox();
            this.txbSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.listReceive = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txbClienIp
            // 
            this.txbClienIp.Location = new System.Drawing.Point(70, 8);
            this.txbClienIp.Name = "txbClienIp";
            this.txbClienIp.Size = new System.Drawing.Size(100, 20);
            this.txbClienIp.TabIndex = 0;
            this.txbClienIp.Text = "127.0.0.1";
            // 
            // lbClientIp
            // 
            this.lbClientIp.AutoSize = true;
            this.lbClientIp.Location = new System.Drawing.Point(12, 15);
            this.lbClientIp.Name = "lbClientIp";
            this.lbClientIp.Size = new System.Drawing.Size(46, 13);
            this.lbClientIp.TabIndex = 2;
            this.lbClientIp.Text = "Client IP";
            // 
            // lbClientPort
            // 
            this.lbClientPort.AutoSize = true;
            this.lbClientPort.Location = new System.Drawing.Point(12, 42);
            this.lbClientPort.Name = "lbClientPort";
            this.lbClientPort.Size = new System.Drawing.Size(51, 13);
            this.lbClientPort.TabIndex = 3;
            this.lbClientPort.Text = "Clientport";
            // 
            // lbServertPort
            // 
            this.lbServertPort.AutoSize = true;
            this.lbServertPort.Location = new System.Drawing.Point(404, 42);
            this.lbServertPort.Name = "lbServertPort";
            this.lbServertPort.Size = new System.Drawing.Size(59, 13);
            this.lbServertPort.TabIndex = 7;
            this.lbServertPort.Text = "Server port";
            // 
            // lbServertIp
            // 
            this.lbServertIp.AutoSize = true;
            this.lbServertIp.Location = new System.Drawing.Point(404, 15);
            this.lbServertIp.Name = "lbServertIp";
            this.lbServertIp.Size = new System.Drawing.Size(51, 13);
            this.lbServertIp.TabIndex = 6;
            this.lbServertIp.Text = "Server IP";
            // 
            // btnCreateClient
            // 
            this.btnCreateClient.Location = new System.Drawing.Point(12, 64);
            this.btnCreateClient.Name = "btnCreateClient";
            this.btnCreateClient.Size = new System.Drawing.Size(164, 23);
            this.btnCreateClient.TabIndex = 8;
            this.btnCreateClient.Text = "Create Client";
            this.btnCreateClient.UseVisualStyleBackColor = true;
            this.btnCreateClient.Click += new System.EventHandler(this.btnCreateClient_Click);
            // 
            // btnCreateServer
            // 
            this.btnCreateServer.Location = new System.Drawing.Point(407, 64);
            this.btnCreateServer.Name = "btnCreateServer";
            this.btnCreateServer.Size = new System.Drawing.Size(152, 23);
            this.btnCreateServer.TabIndex = 9;
            this.btnCreateServer.Text = "Create Server";
            this.btnCreateServer.UseVisualStyleBackColor = true;
            this.btnCreateServer.Click += new System.EventHandler(this.btnCreateServer_Click);
            // 
            // txbServerPort
            // 
            this.txbServerPort.Location = new System.Drawing.Point(462, 34);
            this.txbServerPort.Name = "txbServerPort";
            this.txbServerPort.Size = new System.Drawing.Size(100, 20);
            this.txbServerPort.TabIndex = 10;
            this.txbServerPort.Text = "11000";
            // 
            // txbClientPort
            // 
            this.txbClientPort.Location = new System.Drawing.Point(69, 34);
            this.txbClientPort.Name = "txbClientPort";
            this.txbClientPort.Size = new System.Drawing.Size(100, 20);
            this.txbClientPort.TabIndex = 11;
            this.txbClientPort.Text = "11000";
            // 
            // txbServerIp
            // 
            this.txbServerIp.Location = new System.Drawing.Point(462, 8);
            this.txbServerIp.Name = "txbServerIp";
            this.txbServerIp.Size = new System.Drawing.Size(100, 20);
            this.txbServerIp.TabIndex = 12;
            this.txbServerIp.Text = "127.0.0.1";
            // 
            // listText
            // 
            this.listText.FormattingEnabled = true;
            this.listText.Location = new System.Drawing.Point(12, 94);
            this.listText.MultiColumn = true;
            this.listText.Name = "listText";
            this.listText.Size = new System.Drawing.Size(408, 290);
            this.listText.TabIndex = 13;
            // 
            // txbSend
            // 
            this.txbSend.Location = new System.Drawing.Point(15, 391);
            this.txbSend.Multiline = true;
            this.txbSend.Name = "txbSend";
            this.txbSend.Size = new System.Drawing.Size(467, 59);
            this.txbSend.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(489, 391);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(73, 59);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // listReceive
            // 
            this.listReceive.FormattingEnabled = true;
            this.listReceive.Location = new System.Drawing.Point(426, 94);
            this.listReceive.Name = "listReceive";
            this.listReceive.Size = new System.Drawing.Size(133, 290);
            this.listReceive.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 462);
            this.Controls.Add(this.listReceive);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbSend);
            this.Controls.Add(this.listText);
            this.Controls.Add(this.txbServerIp);
            this.Controls.Add(this.txbClientPort);
            this.Controls.Add(this.txbServerPort);
            this.Controls.Add(this.btnCreateServer);
            this.Controls.Add(this.btnCreateClient);
            this.Controls.Add(this.lbServertPort);
            this.Controls.Add(this.lbServertIp);
            this.Controls.Add(this.lbClientPort);
            this.Controls.Add(this.lbClientIp);
            this.Controls.Add(this.txbClienIp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbClienIp;
        private System.Windows.Forms.Label lbClientIp;
        private System.Windows.Forms.Label lbClientPort;
        private System.Windows.Forms.Label lbServertPort;
        private System.Windows.Forms.Label lbServertIp;
        private System.Windows.Forms.Button btnCreateClient;
        private System.Windows.Forms.Button btnCreateServer;
        private System.Windows.Forms.TextBox txbServerPort;
        private System.Windows.Forms.TextBox txbClientPort;
        private System.Windows.Forms.TextBox txbServerIp;
        private System.Windows.Forms.ListBox listText;
        private System.Windows.Forms.TextBox txbSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ListBox listReceive;
    }
}

