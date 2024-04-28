using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Globalization;

namespace SocketClient
{
    // SocketClient類別，用於與伺服器通訊
    public partial class SocketClient : Form
    {
        // 定義執行緒變數fetchFile和TcpClient變數tcpClient
        Thread? fetchFile;
        TcpClient? tcpClient = null;

        // SocketClient類別的建構函式
        public SocketClient()
        {
            InitializeComponent();
        }

        // Start按鈕的點擊事件處理函式
        public void Start_Click(object sender, EventArgs e)
        {
            try
            {
                // 創建新的執行緒來執行fetch_file函式
                fetchFile = new Thread(fetch_file);
                fetchFile.Start();
            }
            catch
            {
            }
        }

        // 建立IPEndPoint物件的函式
        public IPEndPoint CreateIPEndPoint(string IP, string Port)
        {
            IPAddress? ip;
            if (!IPAddress.TryParse(IP, out ip))
            {
                throw new FormatException("Invalid ip adress");
            }
            int port;
            if (!int.TryParse(Port, NumberStyles.None, NumberFormatInfo.CurrentInfo, out port))
            {
                throw new FormatException("Invalid port");
            }
            return new IPEndPoint(ip, port);
        }

        // 擷取檔案的函式
        public void fetch_file()
        {
            try
            {
                // 解析IP和Port，建立IPEndPoint物件
                IPEndPoint ipEnd = CreateIPEndPoint(IP.Text, port.Text);
                // 創建新的TcpClient物件並嘗試與伺服器連接
                tcpClient = new TcpClient();
                if (tcpClient.ConnectAsync(ipEnd).Wait(1000))
                {
                    NetworkStream stream = tcpClient.GetStream();
                    if (stream != null)
                    {                        
                        if (!Directory.Exists(path.Text))
                        {
                            Directory.CreateDirectory(path.Text);
                        }
                        int bufferSize = 1024;
                        int bytesRead = 0;
                        int allBytesRead = 0;
                        string message = "(Get)" + file.Text;
                        byte[] sendBuffer = Encoding.UTF8.GetBytes(message);
                        stream.Write(sendBuffer);
                        byte[] length = new byte[4];
                        bytesRead = stream.Read(length, 0, 4);
                        string reciveHeader = Encoding.UTF8.GetString(length, 0, length.Length);
                        int dataLength;

                        if (reciveHeader.StartsWith("*Err"))
                        {
                            statusinfo.Text = "Error: file not found.";
                            stream.Close();
                            tcpClient.Close();
                            return;
                        }
                        else
                        {
                            dataLength = BitConverter.ToInt32(length, 0);
                        }

                        int bytesLeft = dataLength;
                        byte[] data = new byte[dataLength];

                        while (bytesLeft > 0)
                        {
                            int nextPacketSize = (bytesLeft > bufferSize) ? bufferSize : bytesLeft;

                            bytesRead = stream.Read(data, allBytesRead, nextPacketSize);
                            allBytesRead += bytesRead;
                            bytesLeft -= bytesRead;
                        }
                        File.WriteAllBytes($"{path.Text}\\{file.Text}", data);
                        statusinfo.Text = "Success.";
                        stream.Close();
                        tcpClient.Close();
                    }
                }
                else
                    statusinfo.Text = "Error: can't connect to server.";
            }
            catch (Exception err)
            {
                statusinfo.Text = $"Error:  {err.Message}";
            }
            finally
            {
                if (tcpClient != null)
                    tcpClient.Close();
            }
        }
        
        // 覆寫WndProc函式，以處理窗口訊息
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            {
                if(tcpClient != null)
                    tcpClient.Close();
            }
            base.WndProc(ref m);
        }
    }
}
