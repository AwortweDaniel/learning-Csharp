using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatServer
{
    public partial class Form1 : Form
    {
        private TcpListener server;
        private List<ClientHandler> clients;
        private bool isRunning;
        private Thread serverThread;

        // UI Controls
        private TextBox txtPort;
        private Button btnStart;
        private Button btnStop;
        private RichTextBox rtbServerLog;
        private ListBox lstClients;
        private Label lblStatus;

        public Form1()
        {
            InitializeControls();
            clients = new List<ClientHandler>();
        }

        private void InitializeControls()
        {
            this.txtPort = new TextBox();
            this.btnStart = new Button();
            this.btnStop = new Button();
            this.rtbServerLog = new RichTextBox();
            this.lstClients = new ListBox();
            this.lblStatus = new Label();
            this.SuspendLayout();

            // Form
            this.Text = "Chat Server";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Port TextBox
            this.txtPort.Location = new System.Drawing.Point(12, 12);
            this.txtPort.Size = new System.Drawing.Size(100, 23);
            this.txtPort.Text = "8888";
            this.Controls.Add(this.txtPort);

            // Start Button
            this.btnStart.Location = new System.Drawing.Point(125, 12);
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.Text = "Start Server";
            this.btnStart.Click += new EventHandler(this.btnStart_Click);
            this.Controls.Add(this.btnStart);

            // Stop Button
            this.btnStop.Location = new System.Drawing.Point(210, 12);
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.Text = "Stop Server";
            this.btnStop.Enabled = false;
            this.btnStop.Click += new EventHandler(this.btnStop_Click);
            this.Controls.Add(this.btnStop);

            // Status Label
            this.lblStatus.Location = new System.Drawing.Point(300, 16);
            this.lblStatus.Size = new System.Drawing.Size(200, 20);
            this.lblStatus.Text = "Server Stopped";
            this.Controls.Add(this.lblStatus);

            // Server Log
            this.rtbServerLog.Location = new System.Drawing.Point(12, 50);
            this.rtbServerLog.Size = new System.Drawing.Size(560, 500);
            this.rtbServerLog.ReadOnly = true;
            this.rtbServerLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            this.Controls.Add(this.rtbServerLog);

            // Clients List
            this.lstClients.Location = new System.Drawing.Point(590, 50);
            this.lstClients.Size = new System.Drawing.Size(180, 500);
            this.Controls.Add(this.lstClients);

            this.ResumeLayout(false);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int port = int.Parse(txtPort.Text);
                server = new TcpListener(IPAddress.Any, port);
                server.Start();
                isRunning = true;

                serverThread = new Thread(AcceptClients);
                serverThread.Start();

                btnStart.Enabled = false;
                btnStop.Enabled = true;
                lblStatus.Text = $"Server Running on Port {port}";
                LogMessage($"Server started on port {port}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting server: {ex.Message}");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isRunning = false;
            server?.Stop();

            // Disconnect all clients
            foreach (var client in clients.ToArray())
            {
                client.Disconnect();
            }
            clients.Clear();

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblStatus.Text = "Server Stopped";
            LogMessage("Server stopped");
            UpdateClientsList();
        }

        private void AcceptClients()
        {
            while (isRunning)
            {
                try
                {
                    TcpClient tcpClient = server.AcceptTcpClient();
                    ClientHandler client = new ClientHandler(tcpClient, this);
                    clients.Add(client);

                    Thread clientThread = new Thread(client.HandleClient);
                    clientThread.Start();

                    LogMessage($"Client connected: {tcpClient.Client.RemoteEndPoint}");
                    UpdateClientsList();
                }
                catch (Exception ex)
                {
                    if (isRunning)
                        LogMessage($"Error accepting client: {ex.Message}");
                }
            }
        }

        public void RemoveClient(ClientHandler client)
        {
            clients.Remove(client);
            LogMessage($"Client disconnected: {client.ClientName}");
            UpdateClientsList();
        }

        public void BroadcastMessage(string message, ClientHandler sender)
        {
            LogMessage($"Broadcasting: {message}");

            foreach (var client in clients.ToArray())
            {
                if (client != sender && client.IsConnected)
                {
                    client.SendMessage(message);
                }
            }
        }

        private void LogMessage(string message)
        {
            if (rtbServerLog.InvokeRequired)
            {
                rtbServerLog.Invoke(new Action(() => {
                    rtbServerLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\n");
                    rtbServerLog.ScrollToCaret();
                }));
            }
            else
            {
                rtbServerLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\n");
                rtbServerLog.ScrollToCaret();
            }
        }

        private void UpdateClientsList()
        {
            if (lstClients.InvokeRequired)
            {
                lstClients.Invoke(new Action(() => {
                    lstClients.Items.Clear();
                    foreach (var client in clients)
                    {
                        if (client.IsConnected)
                            lstClients.Items.Add(client.ClientName);
                    }
                }));
            }
            else
            {
                lstClients.Items.Clear();
                foreach (var client in clients)
                {
                    if (client.IsConnected)
                        lstClients.Items.Add(client.ClientName);
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isRunning)
            {
                btnStop_Click(null, null);
            }
            base.OnFormClosing(e);
        }
    }

    public class ClientHandler
    {
        private TcpClient client;
        private NetworkStream stream;
        private Form1 server;
        public string ClientName { get; private set; }
        public bool IsConnected { get; private set; }

        public ClientHandler(TcpClient client, Form1 server)
        {
            this.client = client;
            this.server = server;
            this.stream = client.GetStream();
            this.IsConnected = true;
            this.ClientName = client.Client.RemoteEndPoint.ToString();
        }

        public void HandleClient()
        {
            byte[] buffer = new byte[1024];

            try
            {
                while (IsConnected && client.Connected)
                {
                    int bytesRead = stream.Read(buffer, 0, buffer.Length);
                    if (bytesRead == 0) break;

                    string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                    // Handle name setting
                    if (message.StartsWith("NAME:"))
                    {
                        ClientName = message.Substring(5);
                        server.BroadcastMessage($"{ClientName} joined the chat", this);
                        continue;
                    }

                    // Broadcast message to all other clients
                    server.BroadcastMessage($"{ClientName}: {message}", this);
                }
            }
            catch (Exception)
            {
                // Client disconnected
            }
            finally
            {
                Disconnect();
            }
        }

        public void SendMessage(string message)
        {
            try
            {
                if (IsConnected && client.Connected)
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                }
            }
            catch (Exception)
            {
                Disconnect();
            }
        }

        public void Disconnect()
        {
            if (IsConnected)
            {
                IsConnected = false;
                stream?.Close();
                client?.Close();
                server.RemoveClient(this);
            }
        }
    }
}