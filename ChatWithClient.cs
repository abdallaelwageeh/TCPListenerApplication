using System;
using System.Drawing;
using System.Net.Sockets;
using System.Runtime.InteropServices;
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
            var encodingValue = ((EncodingObject)SendEncoding.SelectedItem).Name;
            var encoder = Encoding.GetEncoding(encodingValue);
            var bytes = encoder.GetBytes(ConvertHexCharacters(sendArea.Text));
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
        private void ChatWithClient_Load(object sender, EventArgs e)
        {
            //Fill ComboBox With Data
            ReceiveEncoding.DataSource = new ConstantData().Encodings;
            ReceiveEncoding.DisplayMember = "DisplayName";
            ReceiveEncoding.ValueMember = "Name";
            //Fill ComboBox With Data
            SendEncoding.DataSource = new ConstantData().Encodings;
            SendEncoding.DisplayMember = "DisplayName";
            SendEncoding.ValueMember = "Name";
        }
        //Function To retrive the value of the ReceiveEncoding to another Thread
        public string GetReceiveEncodingValue()
        {
            string encodingValue = null;
            ReceiveEncoding.Invoke(new Action(()=> encodingValue=((EncodingObject)SendEncoding.SelectedItem).Name));
            return encodingValue;
        }
        //Function to convert Every Hex Character With Scape character to Unicode string
        private string ConvertHexCharacters(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == '$')
                {
                    if (i != message.Length - 1)
                    {
                        if (message[i + 1] == '$')
                        {
                            i++;
                            continue;
                        }
                        else
                        {
                            try
                            {
                                string item = message.Substring(i + 1, 2);
                                string itemAfter = null;
                                try
                                {
                                    itemAfter = System.Convert.ToChar(System.Convert.ToUInt32(item, 16)).ToString();
                                }
                                catch (Exception)
                                {
                                    continue;
                                }
                                message = message.Replace("$" + item, itemAfter);
                            }
                            catch (Exception)
                            {
                                Log($"Exception While Changing Hex Character You Wrote a wrong Hex Character\n", LogType.Error, receieveArea);
                                continue;
                            }
                        }
                    }
                }
            }
            return message;
        }
        private void SendArea_Enter(object sender, EventArgs e)
        {
            notification.Show("If you Need To Write Hex value you Have to use $ as a scape Character", sendArea,10,10,2000);
        }
    }
}
