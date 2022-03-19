using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace KeyEventDetector
{
    public partial class Form1 : Form
    {
        private ArrayList keysPushed;

        public Form1()
        {
            InitializeComponent();
            keysPushed = new ArrayList();
            label5.Text = String.Empty;
            label3.Text = String.Empty;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            string actual_cord = e.Location.X + ":" + e.Location.Y;
            string information = "Mouse position (x, y): "  + actual_cord;
            label4.Text = information;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label2.Text = "Pressed keys: ";
            keysPushed.Add(e.KeyCode);
            foreach (var keysStr in keysPushed)
            {
                label2.Text += keysStr + " ";
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label2.Text = "Pressed keys: ";
            keysPushed.Remove(e.KeyCode);
            foreach (var keysStr in keysPushed)
            {
                label2.Text += keysStr + " ";
            }
        }

        private async void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            label5.Text = "Mouse click is pressed!";
            await Task.Delay(100);
            label5.Text = "";
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            label3.Text = "Window is being resized!";
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            label3.Text = "";
        }

        private async void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            label5.Text = "Double mouse click is pressed!";
            await Task.Delay(100);
            label5.Text = "";
        }
    }
}
