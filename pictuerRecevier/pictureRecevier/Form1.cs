using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace pictureRecevier;

public partial class Form1 : Form // 
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnReceive_Click(object sender, EventArgs e)
    {
        Image_Receiver();
    }

    void Image_Receiver()
    {
        // Listen on port 5020
        TcpListener tcpListener = new TcpListener(IPAddress.Any, 5020);

        tcpListener.Start();

        MessageBox.Show("Waiting for client...");

        Socket mySocket = tcpListener.AcceptSocket();

        NetworkStream networkStream = new NetworkStream(mySocket);

        pictureBox1.Image = Image.FromStream(networkStream);

        networkStream.Close();
        mySocket.Close();
        tcpListener.Stop();

        MessageBox.Show("Image received successfully!");
    }
}