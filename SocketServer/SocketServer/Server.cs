using System.Net;
using System.Net.Sockets;
using System.Text;

// SocketServer類別，用於建立TCP伺服器
namespace SocketServer
{
    // SocketServer類別，繼承自Windows Forms的Form類別
    public partial class SocketServer : System.Windows.Forms.Form
    {
        // 定義TcpListener物件server和執行緒物件serverThread，以及執行緒運行狀態標誌executing
        TcpListener? server = null;
        Thread? serverThread;
        bool executing = true;
        const int headerSize = 4;
        const int bufferSize = 1024;
        const int commandSize = 5;

        // SocketServer類別的建構函式
        public SocketServer()
        {
            InitializeComponent();
        }
        
        // 建立TCP伺服器的函式
        public bool ServerSocketCreate(int port)
        {
            try
            {                
                server = new TcpListener(IPAddress.Any, port);
                server.Start();
                return true;
            }
            catch
            {
                if (server != null)
                    server.Stop();
                return false;
            }
        }

        // 啟動伺服器的函式
        public void ServerStart()
        {
            try
            {
                Byte[] bytes = new Byte[256];
                String? data = null;
                String filename = "";
                if (!ServerSocketCreate(8888))
                    return;
                if (server == null)
                    return;
                while (executing)
                {
                    TcpClient? client;
                    client  = server.AcceptTcpClient();
                    IPEndPoint? remAddr = client.Client.RemoteEndPoint as IPEndPoint;
                    string clientIPAddress = $"{remAddr?.Address}";
                    IP.Text = clientIPAddress;
                    string clientPortAddress = $"{remAddr?.Port}";
                    Port.Text = clientPortAddress;
                    data = null;
                    NetworkStream? stream = client.GetStream();
                    int index;
                    while ((index = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        data = Encoding.UTF8.GetString(bytes, 0, index);
                        if (data.StartsWith("(Get)"))
                        {
                            filename = data.Remove(0, commandSize);
                            file.Text = filename;
                        }
                        if (File.Exists($"{filename}"))
                        {
                            byte[] dataContent = File.ReadAllBytes(filename);
                            byte[] dataLength = BitConverter.GetBytes(dataContent.Length);
                            byte[] package = new byte[headerSize + dataContent.Length];
                            dataLength.CopyTo(package, 0);//Write size as header
                            dataContent.CopyTo(package, headerSize);//Write content
                            int bytesSent = 0;
                            int bytesLeft = package.Length;
                            while (bytesLeft > 0)
                            {
                                int nextPacketSize = (bytesLeft > bufferSize) ? bufferSize : bytesLeft;

                                stream.Write(package, bytesSent, nextPacketSize);
                                bytesSent += nextPacketSize;
                                bytesLeft -= nextPacketSize;
                            }
                            break;
                        }
                        else//Write error
                        {
                            byte[] writeBuffer = Encoding.UTF8.GetBytes("*Err");
                            stream.Write(writeBuffer, 0, writeBuffer.GetLength(0));
                            break;
                        }
                    }
                    stream.Close();
                }
            }
            catch
            {
            }
            finally
            {
                if (server != null)
                    server.Stop();
            }
        }

        // 覆寫WndProc函式，以處理窗口訊息
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            if (m.Msg == WM_SYSCOMMAND && (int)m.WParam == SC_CLOSE)
            {
                if (server != null)
                    server.Stop();
                executing = false;               
            }
            base.WndProc(ref m);
        }

        // Form載入事件處理函式，開始執行伺服器
        private void Form_Load(object sender, EventArgs e)
        {
            serverThread = new Thread(new ThreadStart(this.ServerStart));
            serverThread.Start();
        }
    }
}
