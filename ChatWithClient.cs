using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static TCPListenerApplication.UiRuntimeChange;

namespace TCPListenerApplication
{
    public partial class ChatWithClient : Form
    {
        private NetworkStream ClientStream { get; set; }
        public CancellationTokenSource Cts { get; private set; }
        public string ClientInfo { get; private set; }
        private Point StartPoint = new Point(0, 0);
        private bool Drag = false;
        public ChatWithClient(NetworkStream stream,string client)
        {
            InitializeComponent();
            ClientStream = stream;
            Cts = new CancellationTokenSource();
            ClientInfo = client;
            clientInfo.Text = ClientInfo;
        }

        private void Send_Click(object sender, EventArgs e)
        {
            if (sendArea.Text == string.Empty)
            {
                UiRuntimeChange.Log("You Have to Write Something To Send It ....\n", LogType.Error, receieveArea);
                return;
            }
            var bytes = Encoding.ASCII.GetBytes(sendArea.Text);
            ClientStream.Write(bytes, 0, bytes.Length);
            sendArea.Clear();
            UiRuntimeChange.Log("Your Message Sended Successfully ....\n", LogType.Message, receieveArea);
        }

        public void Label3_Click(object sender, EventArgs e)
        {
            try
            {
                CloseForm();
            }
            catch (Exception Ex)
            {
                UiRuntimeChange.Log($"Exception Ex:{Ex}\n", LogType.Error, receieveArea);
            }
            finally
            {
                this.Close();
            }
        }
        private void ControlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Drag)
            {
                Point point = PointToScreen(e.Location);
                this.Location=new Point(point.X - StartPoint.X, point.Y - StartPoint.Y);
            }
        }

        private void ControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            Drag = true;
            StartPoint = new Point(e.X, e.Y);
        }

        private void ControlPanel_MouseLeave(object sender, EventArgs e)
        {
            Drag = false;
        }
        public void CloseForm()
        {
            Cts.Cancel();
            Thread.Sleep(1000);
            ClientStream.Close();
            ClientStream.Dispose();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            receieveArea.Clear();
        }
    }
}
