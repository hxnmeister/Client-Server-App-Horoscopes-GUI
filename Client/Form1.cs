﻿using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        Socket client;

        public Form1()
        {
            InitializeComponent();
        }

        //Метод "ControlElementsSwitcher" розроблений для зменшення коду, він дозволяє перемикати видимість окремих елементів контролю
        //Параметр "action" потрібен для визначення того яка дія зараз виконується, "connect" або "disconnect"
        private void ControlElementsSwitcher(string action)
        {
            StartButton.Enabled = !StartButton.Enabled;
            IPInputTextBox.Enabled = !IPInputTextBox.Enabled;
            PortInputTextBox.Enabled = !PortInputTextBox.Enabled;

            StopButton.Enabled = !StopButton.Enabled;
            SendButton.Enabled = !SendButton.Enabled;
            ClearButton.Enabled = !ClearButton.Enabled;
            PredictionRequestTextBox.Enabled = !PredictionRequestTextBox.Enabled;

            switch (action)
            {
                case "connect":
                    ServerStatusColorLabel.BackColor = Color.Green;
                    ServerStatusColorLabel.Text = "Connected!";
                    break;
                case "disconnect":
                    ServerStatusColorLabel.BackColor = Color.Red;
                    ServerStatusColorLabel.Text = "Disconnected!";
                    break;
            }
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            int receivedBytes;
            byte[] incomeBuffer = new byte[1024];
            byte[] outcomeBuffer;

            try
            {
                if (string.IsNullOrEmpty(PredictionRequestTextBox.Text))
                {
                    MessageBox.Show("Nothing to send!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string incomeMessage;

                    outcomeBuffer = Encoding.UTF8.GetBytes(PredictionRequestTextBox.Text);
                    client.Send(outcomeBuffer);

                    receivedBytes = client.Receive(incomeBuffer);
                    incomeMessage = Encoding.UTF8.GetString(incomeBuffer, 0, receivedBytes);

                    if(string.IsNullOrEmpty(incomeMessage)) MessageBox.Show("Check your input and try again!", "Not found!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else PredictionsLogTextBox.Text += incomeMessage + "\r\n";
                    PredictionRequestTextBox.Clear();
                }
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message, "Socket exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An exception occurred during sending a message!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PredictionsLogTextBox.Text))
            {
                MessageBox.Show("Nothing to clear!", "Empty field!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PredictionsLogTextBox.Clear();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                client.Connect(new IPEndPoint(IPAddress.Parse(IPInputTextBox.Text), int.Parse(PortInputTextBox.Text)));

                ControlElementsSwitcher("connect");
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message, "Socket exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (SocketException se)
            {
                MessageBox.Show(se.Message, "Socket exception!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                client?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An exception occurred while closing the application.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
