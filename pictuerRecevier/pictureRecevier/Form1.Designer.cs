using System;
using System.Drawing;
using System.Windows.Forms;

namespace pictureRecevier;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private Label label1;
    private Button button1;
    private PictureBox pictureBox1;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();

        label1 = new Label();
        button1 = new Button();
        pictureBox1 = new PictureBox();

        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Text = "Picture Receiver (Server)";

        // Label
        label1.AutoSize = true;
        label1.Location = new Point(20, 20);
        label1.Text = "Waiting for Client...";

        // Button
        button1.Location = new Point(20, 60);
        button1.Size = new Size(140, 40);
        button1.Text = "Receive Image";
        button1.Click += btnReceive_Click;

        // PictureBox
        pictureBox1.Location = new Point(250, 75);
        pictureBox1.Size = new Size(300, 300);
        pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        Controls.Add(label1);
        Controls.Add(button1);
        Controls.Add(pictureBox1);
    }
}