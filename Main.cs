using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TCPListenerApplication.UiRuntimeChange;

namespace TCPListenerApplication
{
    public partial class Main : Form
    {
        public ConcurrentDictionary<string,NetworkStream> Clients { get; set; }
        public CancellationTokenSource Cts { get; set; }
        private TcpListener Listener { get; set; }
        public Main()
        {
            InitializeComponent();
            Cts = new CancellationTokenSource();
        }

        private void Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Cts.Cancel();
            if (Listener != null) Listener.Stop();
            this.Close();
        }

        private void IpAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                if (char.IsPunctuation(e.KeyChar))
                {
                    if (e.KeyChar != '.') e.Handled = true;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void Listen_Click(object sender, EventArgs e)
        {
            if (port.Text == string.Empty || ipAddress.Text == string.Empty)
            {
                UiRuntimeChange.Log("You Have To Enter Port Number and IP Address ...\n",LogType.Error,receiveArea);
                return;
            }
            IPAddress ipAddressValue;
            try
            {
                ipAddressValue = IPAddress.Parse(ipAddress.Text);
            }
            catch (Exception Ex)
            {
                UiRuntimeChange.Log($"This IP Address is Not Parsable\n Ex:{Ex}\n", LogType.Error, receiveArea);
                return;
            }
            try
            {
                Listener = new TcpListener(ipAddressValue, int.Parse(port.Text));
                Listener.Start();
                UiRuntimeChange.Log("Listener is Started Successfully...\n", LogType.Message, receiveArea);
                listen.Enabled = false;
                Clients = new ConcurrentDictionary<string, NetworkStream>();
            }
            catch (Exception Ex)
            {
                UiRuntimeChange.Log($"Exception While Starting Listener\n Ex:{Ex}\n", LogType.Error, receiveArea);
                return;
            }

            Task.Factory.StartNew(() =>
            {
                while (!Cts.Token.IsCancellationRequested)
                {
                    try
                    {
                        var client = Listener.AcceptTcpClient();
                        UiRuntimeChange.Log($"Client Is Connected : {client.Client.RemoteEndPoint}\n", LogType.Message, receiveArea);
                        var ipClient = client.Client.RemoteEndPoint.ToString();
                        Clients.AddOrUpdate(ipClient, client.GetStream(), (key, value) => Clients[key] = client.GetStream());
                        clientsList.Invoke(new Action(() => { clientsList.DataSource = Clients.Keys; }));
                    }
                    catch (Exception Ex) 
                    {
                        if (!Cts.IsCancellationRequested)
                        {
                            UiRuntimeChange.Log($"Exception While Listening\nEx:{Ex}\n", LogType.Error, receiveArea);
                        }
                    }
                }
            },Cts.Token);
        }
        
        private void StartChat_Click(object sender, EventArgs e)
        {
            if (clientsList.SelectedItem == null) return;
            var index = clientsList.SelectedItem.ToString();
            var stream = Clients[index];
            var chat = new ChatWithClient(stream,index);
            chat.Show();
            Task.Factory.StartNew(async() =>
            {
                var byteBuffer = new byte[4000];
                while (!chat.Cts.Token.IsCancellationRequested)
                {
                    try
                    {
                        int len = await stream.ReadAsync(byteBuffer, 0, 4000, chat.Cts.Token);
                        string encodingValue=chat.GetReceiveEncodingValue();
                        var encoder = Encoding.GetEncoding(encodingValue);
                        var message = encoder.GetString(byteBuffer, 0, len);
                        if (len==0)
                        {
                            UiRuntimeChange.Log($"Client is Closed ...\nWe Have To Close This Session...\n", LogType.Disconnect, chat.receieveArea);
                            UiRuntimeChange.Log($"{chat.ClientInfo} is Closed ...\n",LogType.Disconnect,receiveArea);
                            await Task.Factory.StartNew(() =>
                            {
                                try
                                {
                                    chat.Invoke(new Action(()=> 
                                    { 
                                        chat.CloseForm();
                                        chat.Close();
                                    }));
                                    
                                }
                                catch (Exception Ex)
                                {
                                    UiRuntimeChange.Log($"Exception Ex:{Ex}\n", LogType.Error, chat.receieveArea);
                                }
                            });
                            break;
                        }
                        UiRuntimeChange.Log($"Client Send : {message}\n", LogType.Message, chat.receieveArea);
                    }
                    catch (Exception Ex)
                    {
                        UiRuntimeChange.Log($"Exception Ex:{Ex}", LogType.Error, chat.receieveArea);
                    }
                }
            },Cts.Token);
            Clients.TryRemove(index, out NetworkStream outStream);
            clientsList.Invoke(new Action(() => { clientsList.DataSource = Clients.Keys; }));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            receiveArea.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            receiveArea.Select(0, 0);
            receiveArea.ScrollToCaret();
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            if (clientsList.SelectedItem == null) return;
            var index = clientsList.SelectedItem.ToString();
            var stream = Clients[index];
            try
            {
                stream.Close();
                UiRuntimeChange.Log($"Client is Closed ...\n", LogType.Disconnect, receiveArea);
                stream.Dispose();
                if (Clients.TryRemove(index, out NetworkStream clientStream))
                {
                    UiRuntimeChange.Log($"Client is Removed Successfully\n", LogType.Message, receiveArea);
                    clientsList.DataSource = Clients.Keys;
                }
            }
            catch (Exception Ex)
            {
                UiRuntimeChange.Log($"Error While Deleting the Client\nEx:{Ex}\n", LogType.Error, receiveArea);
            }
        }
    }
    
}
