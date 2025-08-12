using System;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatClient
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private bool isConnected;

        // UI Controls
        private TextBox txtServerIP;
        private TextBox txtPort;
        private TextBox txtUsername;
        private Button btnConnect;
        private Button btnDisconnect;
        private RichTextBox rtbChatHistory;
        private TextBox txtMessage;
        private Button btnSend;
        private Label lblStatus;
        private Label lblServerIP;
        private Label lblPort;
        private Label lblUsername;

        public Form1()
        {
            InitializeControls();
        }

        private void InitializeControls()
        {
            this.txtServerIP = new TextBox();
            this.txtPort = new TextBox();
            this.txtUsername = new TextBox();
            this.btnConnect = new Button();
            this.btnDisconnect = new Button();
            this.rtbChatHistory = new RichTextBox();
            this.txtMessage = new TextBox();
            this.btnSend = new Button();
            this.lblStatus = new Label();
            this.lblServerIP = new Label();
            this.lblPort = new Label();
            this.lblUsername = new Label();
            this.SuspendLayout();

            // Form
            this.Text = "Chat Client";
            this.Size = new System.Drawing.Size(600, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Server IP Label
            this.lblServerIP.Location = new System.Drawing.Point(12, 15);
            this.lblServerIP.Size = new System.Drawing.Size(60, 20);
            this.lblServerIP.Text = "Server IP:";
            this.Controls.Add(this.lblServerIP);

            // Server IP TextBox
            this.txtServerIP.Location = new System.Drawing.Point(75, 12);
            this.txtServerIP.Size = new System.Drawing.Size(100, 23);
            this.txtServerIP.Text = "127.0.0.1";
            this.Controls.Add(this.txtServerIP);

            // Port Label
            this.lblPort.Location = new System.Drawing.Point(185, 15);
            this.lblPort.Size = new System.Drawing.Size(35, 20);
            this.lblPort.Text = "Port:";
            this.Controls.Add(this.lblPort);

            // Port TextBox
            this.txtPort.Location = new System.Drawing.Point(220, 12);
            this.txtPort.Size = new System.Drawing.Size(60, 23);
            this.txtPort.Text = "8888";
            this.Controls.Add(this.txtPort);

            // Username Label
            this.lblUsername.Location = new System.Drawing.Point(290, 15);
            this.lblUsername.Size = new System.Drawing.Size(65, 20);
            this.lblUsername.Text = "Username:";
            this.Controls.Add(this.lblUsername);

            // Username TextBox
            this.txtUsername.Location = new System.Drawing.Point(355, 12);
            this.txtUsername.Size = new System.Drawing.Size(100, 23);
            this.Controls.Add(this.txtUsername);

            // Connect Button
            this.btnConnect.Location = new System.Drawing.Point(465, 12);
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new EventHandler(this.btnConnect_Click);
            this.Controls.Add(this.btnConnect);

            // Disconnect Button
            this.btnDisconnect.Location = new System.Drawing.Point(465, 40);
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Click += new EventHandler(this.btnDisconnect_Click);
            this.Controls.Add(this.btnDisconnect);

            // Status Label
            this.lblStatus.Location = new System.Drawing.Point(12, 45);
            this.lblStatus.Size = new System.Drawing.Size(200, 20);
            this.lblStatus.Text = "Disconnected";
            this.Controls.Add(this.lblStatus);

            // Chat History
            this.rtbChatHistory.Location = new System.Drawing.Point(12, 75);
            this.rtbChatHistory.Size = new System.Drawing.Size(560, 320);
            this.rtbChatHistory.ReadOnly = true;
            this.rtbChatHistory.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.Controls.Add(this.rtbChatHistory);

            // Message TextBox
            this.txtMessage.Location = new System.Drawing.Point(12, 410);
            this.txtMessage.Size = new System.Drawing.Size(475, 23);
            this.txtMessage.Enabled = false;
            this.txtMessage.KeyPress += new KeyPressEventHandler(this.txtMessage_KeyPress);
            this.Controls.Add(this.txtMessage);

            // Send Button
            this.btnSend.Location = new System.Drawing.Point(500, 410);
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.Text = "Send";
            this.btnSend.Enabled = false;
            this.btnSend.Click += new EventHandler(this.btnSend_Click);
            this.Controls.Add(this.btnSend);

            this.ResumeLayout(false);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Please enter a username!");
                return;
            }

            try
            {
                string serverIP = txtServerIP.Text;
                int port = int.Parse(txtPort.Text);
                string username = txtUsername.Text;

                client = new TcpClient();
                client.Connect(serverIP, port);
                stream = client.GetStream();
                isConnected = true;

                // Send username to server
                byte[] nameData = Encoding.UTF8.GetBytes($"NAME:{username}");
                stream.Write(nameData, 0, nameData.Length);

                // Start receiving messages
                receiveThread = new Thread(ReceiveMessages);
                receiveThread.Start();

                // Update UI
                btnConnect.Enabled = false;
                btnDisconnect.Enabled = true;
                txtMessage.Enabled = true;
                btnSend.Enabled = true;
                txtServerIP.Enabled = false;
                txtPort.Enabled = false;
                txtUsername.Enabled = false;
                lblStatus.Text = $"Connected as {username}";

                AppendMessage("Connected to server!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            DisconnectFromServer();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendMessage();
                e.Handled = true;
            }
        }

        private void SendMessage()
        {
            if (!string.IsNullOrWhiteSpace(txtMessage.Text) && isConnected)
            {
                try
                {
                    byte[] data = Encoding.UTF8.GetBytes(txtMessage.Text);
                    stream.Write(data, 0, data.Length);
                    AppendMessage($"You: {txtMessage.Text}");
                    txtMessage.Clear();
                }
                catch (Exception)
                {
                    DisconnectFromServer();
                }
            }
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];

            try
            {
                while (isConnected && client.Connected)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    AppendMessage(message);
                }
            }
            catch (Exception)
            {
                // Connection lost
            }
            finally
            {
                if (isConnected)
                {
                    this.Invoke(new Action(() => DisconnectFromServer()));
                }
            }
        }

        private void AppendMessage(string message)
        {
            if (rtbChatHistory.InvokeRequired)
            {
                rtbChatHistory.Invoke(new Action(() => {
                    rtbChatHistory.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\n");
                    rtbChatHistory.ScrollToCaret();
                }));
            }
            else
            {
                rtbChatHistory.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\n");
                rtbChatHistory.ScrollToCaret();
            }
        }

        private void DisconnectFromServer()
        {
            isConnected = false;

            try
            {
                stream?.Close();
                client?.Close();
            }
            catch { }

            // Update UI
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            txtMessage.Enabled = false;
            btnSend.Enabled = false;
            txtServerIP.Enabled = true;
            txtPort.Enabled = true;
            txtUsername.Enabled = true;
            lblStatus.Text = "Disconnected";

            AppendMessage("Disconnected from server!");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isConnected)
            {
                DisconnectFromServer();
            }
            base.OnFormClosing(e);
        }
    }
}