using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.White);
            Font font = new Font("Arial", 15);
            g.DrawString("For all the rules of the game pleas visit \n http://www.google.com", font, brush, 14f, 14f, strFormat);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}