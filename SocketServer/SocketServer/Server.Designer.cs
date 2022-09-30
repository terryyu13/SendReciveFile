namespace SocketServer
{
    partial class SocketServer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IP = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.TextBox();
            this.file = new System.Windows.Forms.TextBox();
            this.ClientIP = new System.Windows.Forms.Label();
            this.ClientPort = new System.Windows.Forms.Label();
            this.Filename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(278, 51);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(264, 30);
            this.IP.TabIndex = 0;
            // 
            // Port
            // 
            this.Port.Location = new System.Drawing.Point(278, 125);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(264, 30);
            this.Port.TabIndex = 1;
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(278, 201);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(264, 30);
            this.file.TabIndex = 2;
            // 
            // ClientIP
            // 
            this.ClientIP.AutoSize = true;
            this.ClientIP.Location = new System.Drawing.Point(158, 58);
            this.ClientIP.Name = "ClientIP";
            this.ClientIP.Size = new System.Drawing.Size(85, 23);
            this.ClientIP.TabIndex = 3;
            this.ClientIP.Text = "Client IP:";
            // 
            // ClientPort
            // 
            this.ClientPort.AutoSize = true;
            this.ClientPort.Location = new System.Drawing.Point(158, 132);
            this.ClientPort.Name = "ClientPort";
            this.ClientPort.Size = new System.Drawing.Size(105, 23);
            this.ClientPort.TabIndex = 4;
            this.ClientPort.Text = "Client Port:";
            // 
            // Filename
            // 
            this.Filename.AutoSize = true;
            this.Filename.Location = new System.Drawing.Point(158, 208);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(91, 23);
            this.Filename.TabIndex = 5;
            this.Filename.Text = "Filename:";
            // 
            // SocketServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 288);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.ClientPort);
            this.Controls.Add(this.ClientIP);
            this.Controls.Add(this.file);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.IP);
            this.Name = "SocketServer";
            this.Text = "SocketServer";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox IP;
        private TextBox Port;
        private TextBox file;
        private Label ClientIP;
        private Label ClientPort;
        private Label Filename;
    }
}