using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
        }

        private void ruls_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
          
            
        }

        private void ruls_Paint(object sender, PaintEventArgs e)
        {
            Form a = new Form();

            a.Show();

            
            TextBox rt = new TextBox();
            rt.TextAlign = HorizontalAlignment.Center;
            rt.Multiline = true;
            rt.Dock = DockStyle.Fill;
            rt.Location = new Point(0, 0);
            rt.ReadOnly = true;
            rt.Text = "For the all the ruls of the game pleas visit http://www.google.com";
            a.Controls.Add(rt);
            a.Text = "sdasdsd";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}