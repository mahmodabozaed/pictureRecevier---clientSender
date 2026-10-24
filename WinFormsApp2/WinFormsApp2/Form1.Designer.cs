using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp2;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private Label lblServer;
    private TextBox txtServer;
    private Button btnSend;
    private PictureBox pictureBox1;
    private ProgressBar progressBar1;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        lblServer = new Label();
        txtServer = new TextBox();
        btnSend = new Button();
        pictureBox1 = new PictureBox();
        progressBar1 = new ProgressBar();

        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();

        // Form
        Text = "My Picture Sender / Client Form";
        ClientSize = new Size(800, 450);

        // Label
        lblServer.AutoSize = true;
        lblServer.Location = new Point(20, 20);
        lblServer.Name = "lblServer";
        lblServer.Text = "Server";

        // TextBox
        txtServer.Location = new Point(80, 17);
        txtServer.Name = "txtServer";
        txtServer.Size = new Size(250, 23);
        txtServer.Text = "localhost";

        // Button
        btnSend.Location = new Point(80, 100);
        btnSend.Name = "btnSend";
        btnSend.Size = new Size(150, 40);
        btnSend.Text = "Send My Picture";
        btnSend.UseVisualStyleBackColor = true;
        btnSend.Click += btnSend_Click;

        // PictureBox
        pictureBox1.Location = new Point(420, 60);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(250, 180);
        pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

        // ProgressBar
        progressBar1.Location = new Point(20, 390);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(740, 25);

        // Add Controls
        Controls.Add(lblServer);
        Controls.Add(txtServer);
        Controls.Add(btnSend);
        Controls.Add(pictureBox1);
        Controls.Add(progressBar1);

        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
}