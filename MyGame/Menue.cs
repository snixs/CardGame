using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Menue : Form
    {
        public Menue()
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
            Ruls a = new Ruls();
            a.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game a = new Game();
            this.Hide();
            a.Show();
        }


    }
}