using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        byte[] incomeBuffer = new byte[1024];
        byte[] outcomeBuffer;
        Socket client;

        public Form1()
        {
            InitializeComponent();
        }

        private void ControlElementsSwitcher(string action)
        {
            StartButton.Enabled = !StartButton.Enabled;
            IPInputTextBox.Enabled = !IPInputTextBox.Enabled;
            PortInputTextBox.Enabled = !PortInputTextBox.Enabled;

            StopButton.Enabled = !StopButton.Enabled;
            SendButton.Enabled = !SendButton.Enabled;
            ClearButton.Enabled = !ClearButton.Enabled;
            PredictionRequestTextBox.Enabled = !PredictionRequestTextBox.Enabled;

            ServerStatusColorLabel.Text = "Connected!";

            switch (action)
            {
                case "connect":
                    ServerStatusColorLabel.BackColor = Color.Green;
                    break;
                case "disconnect":
                    ServerStatusColorLabel.BackColor = Color.Red;
                    break;
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                client.Connect(new IPEndPoint(IPAddress.Parse(IPInputTextBox.Text), int.Parse(PortInputTextBox.Text)));

                ControlElementsSwitcher("connect");
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
                client.Shutdown(SocketShutdown.Both);
                client.Close();

                ControlElementsSwitcher("disconnect");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
