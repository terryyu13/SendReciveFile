namespace SocketClient
{
    partial class SocketClient
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
            this.ServerIP = new System.Windows.Forms.Label();
            this.ServerPort = new System.Windows.Forms.Label();
            this.Filename = new System.Windows.Forms.Label();
            this.Filepath = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.IP = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.file = new System.Windows.Forms.TextBox();
            this.path = new System.Windows.Forms.TextBox();
            this.statusinfo = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerIP
            // 
            this.ServerIP.AutoSize = true;
            this.ServerIP.Location = new System.Drawing.Point(59, 39);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(88, 23);
            this.ServerIP.TabIndex = 0;
            this.ServerIP.Text = "Server IP:";
            // 
            // ServerPort
            // 
            this.ServerPort.AutoSize = true;
            this.ServerPort.Location = new System.Drawing.Point(59, 96);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(108, 23);
            this.ServerPort.TabIndex = 1;
            this.ServerPort.Text = "Server Port:";
            // 
            // Filename
            // 
            this.Filename.AutoSize = true;
            this.Filename.Location = new System.Drawing.Point(59, 159);
            this.Filename.Name = "Filename";
            this.Filename.Size = new System.Drawing.Size(91, 23);
            this.Filename.TabIndex = 2;
            this.Filename.Text = "Filename:";
            // 
            // Filepath
            // 
            this.Filepath.AutoSize = true;
            this.Filepath.Location = new System.Drawing.Point(59, 227);
            this.Filepath.Name = "Filepath";
            this.Filepath.Size = new System.Drawing.Size(87, 23);
            this.Filepath.TabIndex = 3;
            this.Filepath.Text = "File path:";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(59, 291);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(67, 23);
            this.Status.TabIndex = 4;
            this.Status.Text = "Status:";
            // 
            // IP
            // 
            this.IP.Location = new System.Drawing.Point(218, 32);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(200, 30);
            this.IP.TabIndex = 5;
            this.IP.Text = "127.0.0.1";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(218, 96);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(200, 30);
            this.port.TabIndex = 6;
            this.port.Text = "8888";
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(218, 159);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(200, 30);
            this.file.TabIndex = 7;
            this.file.Text = "test.txt";
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(218, 227);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(200, 30);
            this.path.TabIndex = 8;
            this.path.Text = "C:\\test\\";
            // 
            // statusinfo
            // 
            this.statusinfo.Location = new System.Drawing.Point(218, 284);
            this.statusinfo.Name = "statusinfo";
            this.statusinfo.Size = new System.Drawing.Size(399, 30);
            this.statusinfo.TabIndex = 9;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(505, 184);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(112, 73);
            this.Start.TabIndex = 10;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // SocketClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 342);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.statusinfo);
            this.Controls.Add(this.path);
            this.Controls.Add(this.file);
            this.Controls.Add(this.port);
            this.Controls.Add(this.IP);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Filepath);
            this.Controls.Add(this.Filename);
            this.Controls.Add(this.ServerPort);
            this.Controls.Add(this.ServerIP);
            this.Name = "SocketClient";
            this.Text = "SocketClient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ServerIP;
        private Label ServerPort;
        private Label Filename;
        private Label Filepath;
        private Label Status;
        private TextBox IP;
        private TextBox port;
        private TextBox file;
        private TextBox path;
        private TextBox statusinfo;
        private Button Start;
    }
}