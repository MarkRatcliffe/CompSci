using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NetComm;

namespace Host
{
    public partial class MainDisplay : Form
    {
        public MainDisplay()
        {
            InitializeComponent();
        }

        NetComm.Host Server;
        private void MainDisplay_Load(object sender, EventArgs e)
        {
            Server = new NetComm.Host(2020); //Initialize the Server object, connection will use the 2020 port number
            Server.StartConnection(); //Starts listening for incoming clients

            //Adding event handling methods, to handle the server messages
            Server.onConnection += new NetComm.Host.onConnectionEventHandler(Server_onConnection);
            Server.lostConnection += new NetComm.Host.lostConnectionEventHandler(Server_lostConnection);
            Server.DataReceived += new NetComm.Host.DataReceivedEventHandler(Server_DataReceived);
        }

        private void MainDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Server.CloseConnection(); //Closes all of the opened connections and stops listening
        }

        void Server_DataReceived(string ID, byte[] Data)
        {
            Log.AppendText(ID + ": " + ConvertBytesToString(Data) + Environment.NewLine); //Updates the log when a new message arrived, converting the Data bytes to a string
        }

        void Server_lostConnection(string id)
        {
            if (Log.IsDisposed) return; //Fixes the invoke error
            Log.AppendText(id + " disconnected" + Environment.NewLine); //Updates the log textbox when user leaves the room
        }

        void Server_onConnection(string id)
        {
            Log.AppendText(id + " connected!" + Environment.NewLine); //Updates the log textbox when new user joined
        }

        string ConvertBytesToString(byte[] bytes)
        {
            return ASCIIEncoding.ASCII.GetString(bytes);
        }
    }
}
