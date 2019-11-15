using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// need to ass this to use sockets
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Sockets
{
    // Using http://technotif.com/creating-simple-udp-server-client-transfer-data-using-c-vb-net/
    public partial class ChatForm : Form
    {
        private Boolean master;  //used to indicate whether this is the Master(Server) or Slave(Client)
        private int readPort;
        private int writePort;

        private String broadcastAddress = "255.255.255.255";
        private UdpClient receivingClient;
        private UdpClient sendingClient;

        private Queue messageQueue = new Queue(20);  // This is used to store my Queue of Messages
        private System.Windows.Forms.Timer displayTimer;

        String message;

        public ChatForm(Boolean isMaster)
        {
            InitializeComponent();
            master = isMaster;  // save value in attribute
            if (master)
            {
                readPort = 9655;
                writePort = 9654;
            }
            else
            {
                readPort = 9654;
                writePort = 9655;
            }

        }

        // InitializeSender sets up a connection by writing to a specifica Port right across the LAN
        // Change the value of broadcast Address to specific IP if beyond LAN
        private void InitializeSender()   // Initialise client for writing
        {
            // Use broadcastAddress for sending data locally (on LAN), 
            // otherwise you'll need the public (or global) IP address of the machine 
            // that you want to send your data to

            sendingClient = new UdpClient(broadcastAddress, writePort);
            sendingClient.EnableBroadcast = true;
       }

        // InitializReceiver sets up the reading service 
        // It creates a Thread which executes receiver, which continually listens on the readPort
        private void InitializeReceiver()  // Initialise Server to receive
        {
            receivingClient = new UdpClient(readPort);
            // Start listener on another thread
            Thread listener = new Thread(new ThreadStart(Receiver));
            listener.Start();

            displayTimer = new System.Windows.Forms.Timer();
            displayTimer.Interval = 100;  // every 100ms, but starts when we get our first message coming in
            displayTimer.Tick += new EventHandler(updateQueueDisplay);
            displayTimer.Enabled = true;
        }

        // Receiver runs in the listener Thread, conmtinually listens on the readPort
        // When it finds a message it adds it to the message queue for processing
        //  Note it cannot add directly to a listBox as this would make it an unsafe thread
        private void Receiver()  // this is my server waiting for responses
        {
            // Listen for incoming data from any IP on the specified port
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, readPort);
            while (true)  // Notice that i've setup an infinite loop to continually listen for incoming data
            {
                byte[] bytes = receivingClient.Receive(ref endPoint);
                message = Encoding.ASCII.GetString(bytes);
                // CANNOT add received message driectly to the ListBox on display as this is not ThreadSafe

                messageQueue.EnQueue(message.ToString());
                Console.WriteLine(endPoint.Address.ToString() + ":" + message.ToString());
                displayTimer.Start();  // kick off updates on queue now message has arrived
            }
        }


        private void ChatForm_Load(object sender, EventArgs e)
        {
            InitializeSender();
            InitializeReceiver();
        }

        // SendButtonClick takes the message in SendText text area and broadcasts it out
        private void sendButton_Click(object sender, EventArgs e)  // Client sending
        {
            String stringToSend = sendText.Text;
            // Assuming you have a textbox with the data you want to send
            if (! String.IsNullOrEmpty(stringToSend)) 
            {
                Byte[] data = Encoding.ASCII.GetBytes(stringToSend);
                sendingClient.Send(data, data.Length);
            }
            sendText.Text = "";
        }

        private void updateQueueDisplay(object sender, EventArgs e) // connected to displayTimer
        {
            if (messageQueue.Length() != 0)
            {
                receiveText.Items.Add(messageQueue.DeQueue().ToString());
            }
        }

    }
}
