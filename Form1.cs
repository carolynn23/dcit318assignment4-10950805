using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point lastPoint = Point.Empty;
        private List<(Point Start, Point End)> lines = new List<(Point Start, Point End)>();

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize any data or settings when the form loads.
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
                Console.WriteLine($"Mouse Down at {e.Location}");
            }
            textBox1.AppendText("Mouse down\r\n");
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                using (Graphics g = this.CreateGraphics())
                {
                    g.DrawLine(Pens.Black, lastPoint, e.Location);
                }
                lines.Add((lastPoint, e.Location));
                lastPoint = e.Location;
                Console.WriteLine($"Mouse Move to {e.Location}");
            }
            textBox1.AppendText("Mouse move\r\n");
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
                lastPoint = Point.Empty;
                Console.WriteLine($"Mouse Up at {e.Location}");
            }
            textBox1.AppendText("Mouse up\r\n");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var line in lines)
            {
                e.Graphics.DrawLine(Pens.Black, line.Start, line.End);
            }
            textBox1.AppendText("Mouse Form paint");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
