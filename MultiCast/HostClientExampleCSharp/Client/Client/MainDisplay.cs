using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client
{
    public partial class MainDisplay : Form
    {
        public MainDisplay()
        {
            InitializeComponent();
        }

        NetComm.Client client; //The client object used for the communication
        private void MainDisplay_Load(object sender, EventArgs e)
        {
            client = new NetComm.Client(); //Initialize the client object

            //Adding event handling methods for the client
            client.Connected += new NetComm.Client.ConnectedEventHandler(client_Connected);
            client.Disconnected += new NetComm.Client.DisconnectedEventHandler(client_Disconnected);
            client.DataReceived += new NetComm.Client.DataReceivedEventHandler(client_DataReceived);

            //Connecting to the host
            client.Connect("localhost", 2020, "Jack"); //Connecting to the host (on the same machine) with port 2020 and ID "Jack"
        }

        private void MainDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client.isConnected) client.Disconnect(); //Disconnects if the client is connected, closing the communication thread
        }

        void client_DataReceived(byte[] Data, string ID)
        {
            Log.AppendText(ID + ": " + ConvertBytesToString(Data)  + Environment.NewLine); //Updates the log with the current connection state
        }

        void client_Disconnected()
        {
            Log.AppendText("Disconnected from host!" + Environment.NewLine); //Updates the log with the current connection state
        }

        void client_Connected()
        {
            Log.AppendText("Connected succesfully!" + Environment.NewLine); //Updates the log with the current connection state
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            client.SendData(ConvertStringToBytes(ChatMessage.Text)); //Sends the message to the host
            ChatMessage.Clear(); //Clears the chatmessage textbox text
        }

        string ConvertBytesToString(byte[] bytes)
        {
            return ASCIIEncoding.ASCII.GetString(bytes);
        }

        byte[] ConvertStringToBytes(string str)
        {
            return ASCIIEncoding.ASCII.GetBytes(str);
        }
    }
}
