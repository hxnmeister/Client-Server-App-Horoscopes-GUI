using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using static System.Windows.Forms.AxHost;

namespace Server
{
    public partial class Form1 : Form
    {
        private Socket server;
        private Thread dedicatedThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void ThreadMethod()
        {
            int receivedBytes;
            byte[] incomeBuffer = new byte[1024];
            byte[] outcomeBuffer;
            Socket handler;
            string incomeMessage = "";
            string outcomeMessage = "";

            try
            {
                while (true)
                {
                    handler = server.Accept();
                    receivedBytes = handler.Receive(incomeBuffer);
                    incomeMessage = Encoding.UTF8.GetString(incomeBuffer, 0, receivedBytes);

                    if(incomeMessage == "GET_PREDICTIONS")
                    {
                        BacklogTextBox.Invoke(new Action(() => { outcomeMessage = BacklogTextBox.Text; }));
                        outcomeBuffer = Encoding.UTF8.GetBytes(outcomeMessage);
                        handler.Send(outcomeBuffer);
                    }
                    else
                    {
                        BacklogTextBox.Invoke(new Action(() => { BacklogTextBox.Text += $"{DateTime.Now}: {incomeMessage}\r\n"; }));
                    }

                    handler.Shutdown(SocketShutdown.Both);
                    handler.Close();
                }
            }
            catch(SocketException se)
            {
                MessageBox.Show(se.Message, "Socket Exception!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Server exception!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Метод "ControlElementsSwitcher" розроблений для зменшення коду, він дозволяє перемикати видимість окремих елементів контролю
        //Параметр "action" потрібен для визначення того яка дія зараз виконується, "start" або "stop"
        private void ControlElementsSwitcher(string action)
        {
            StopButton.Enabled = !StopButton.Enabled;

            StartButton.Enabled = !StartButton.Enabled;
            IPInputTextBox.Enabled = !IPInputTextBox.Enabled;
            PortInputTextBox.Enabled = !PortInputTextBox.Enabled;

            switch (action)
            {
                case "start":
                    ServerStatusColorLabel.Text = "Started!";
                    ServerStatusColorLabel.BackColor = Color.Green;
                    BacklogTextBox.Text += $"{DateTime.Now}: Server Succsessfully Started!\r\n";
                    break;
                case "stop":
                    ServerStatusColorLabel.Text = "Stoped!";
                    ServerStatusColorLabel.BackColor = Color.Red;
                    BacklogTextBox.Text += $"{DateTime.Now}: Server Succsessfully Stoped!\r\n";
                    break;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                server.Bind(new IPEndPoint(IPAddress.Parse(IPInputTextBox.Text), int.Parse(PortInputTextBox.Text)));
                server.Listen(1000);

                dedicatedThread = new Thread(new ThreadStart((ThreadMethod)));
                dedicatedThread.IsBackground = true;
                dedicatedThread.Start();

                ControlElementsSwitcher("start");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An exception occurred during server startup!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            try
            {
                dedicatedThread.Suspend();
                server.Close();

                ControlElementsSwitcher("stop");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An exception occurred while the server was shutting down!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if(server != null)
                {
                    dedicatedThread.Suspend();
                    server.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An exception occurred while closing the application.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
