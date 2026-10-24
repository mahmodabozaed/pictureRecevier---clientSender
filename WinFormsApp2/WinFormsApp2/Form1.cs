using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Drawing;

namespace WinFormsApp2;

public partial class Form1 : Form 
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnSend_Click(object sender, EventArgs e)
    {
        try
        {
            // Create OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); // OpenFileDialog
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                string mypic_path = openFileDialog1.FileName;

                // Show image in PictureBox
                pictureBox1.Image = Image.FromFile(mypic_path);

                // Convert image to byte array
                MemoryStream ms = new MemoryStream();
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                byte[] arrImage = ms.ToArray();
                ms.Close();

                // Connect to server
                TcpClient myclient = new TcpClient("92.251.139.92", 5020);

                // Get network stream
                NetworkStream myns = myclient.GetStream();

                // Send image
                BinaryWriter mysw = new BinaryWriter(myns);
                mysw.Write(arrImage);
                mysw.Flush();

                // Close everything
                mysw.Close();
                myns.Close();
                myclient.Close();

                MessageBox.Show("Image sent successfully!");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}