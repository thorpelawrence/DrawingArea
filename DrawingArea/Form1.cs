using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.White, 1);
            penSizeUpDown.Value = 1;
            drawingBox.BackColor = Color.Black;
            penColorButton.BackColor = pen.Color;
            backgroundColorButton.BackColor = drawingBox.BackColor;
            backgroundColorButton.ForeColor = Invert(drawingBox.BackColor);
            Clear();
            drawingBox.MouseWheel += new MouseEventHandler(drawingBox_MouseWheel);
        }

        void drawingBox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                penSize += 1;
            else penSize -= 1;
        }

        Bitmap b;
        Point p, pLast;
        Pen pen;

        /// <summary>
        /// Clears the drawing area
        /// </summary>
        void Clear()
        {
            b = new Bitmap(drawingBox.Width, drawingBox.Height);
            drawingBox.Image = b;
        }

        /// <summary>
        /// Returns the colour inverted
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        Color Invert(Color c)
        {
            return Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
        }

        /// <summary>
        /// Triggers when the drawing panel size changes
        /// </summary>
        void ResizeDrawingBox()
        {
            //If new drawing area is larger than current bitmap, resize it and draw original back onto it
            if (b.Width < drawingBox.Width || b.Height < drawingBox.Height)
            {
                Bitmap bResized = new Bitmap(drawingBox.Width, drawingBox.Height);
                Graphics gResized = Graphics.FromImage(bResized);
                gResized.DrawImageUnscaled(b, 0, 0);
                b = bResized;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        void Draw(MouseEventArgs e)
        {
            p = e.Location;
            if (drawingBox.ClientRectangle.Contains(e.Location))
            {
                using (Graphics g = Graphics.FromImage(b))
                    switch (e.Button)
                    {
                        case MouseButtons.Left:
                            g.DrawLine(pen, pLast, p);
                            break;
                        case MouseButtons.Right:
                            g.DrawLine(new Pen(drawingBox.BackColor, 20), pLast, p);
                            break;
                    }
            }
            drawingBox.Image = b;
        }

        /// <summary>
        /// Triggers when drawing area is changed
        /// </summary>
        void PaintDrawingBox()
        {
            pLast = p;
        }

        /// <summary>
        /// Returns colour from a color dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        Color ColorDialog(object sender)
        {
            Color c = Color.White;
            Button buttonSender = sender as Button;
            ColorDialog ColorDialog = new ColorDialog();
            ColorDialog.FullOpen = true;
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                c = ColorDialog.Color;
                buttonSender.BackColor = c;
                buttonSender.ForeColor = Invert(c);
            }
            return c;
        }

        /// <summary>
        /// Set size of pen
        /// </summary>
        float penSize
        {
            set
            {
                if (value <= (float)penSizeUpDown.Maximum && value >= (float)penSizeUpDown.Minimum)
                {
                    pen = new Pen(pen.Color, value);
                    penSizeUpDown.Value = (decimal)value;
                }
            }
            get { return pen.Width; }
        }

        private void drawingBox_MouseMove(object sender, MouseEventArgs e)
        {
            Draw(e);
        }

        private void penColorButton_Click(object sender, EventArgs e)
        {
            pen.Color = ColorDialog(sender);
        }

        private void backgroundColorButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Drawing will be deleted\r\nAre you sure you want to continue?",
                "Delete drawing",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            {
                drawingBox.BackColor = ColorDialog(sender);
                Clear();
            }
        }

        private void penSizeUpDown_ValueChanged(object sender, EventArgs e)
        {
            penSize = (float)penSizeUpDown.Value;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Drawing will be deleted\r\nAre you sure you want to continue?",
                "Delete drawing",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
                Clear();
        }

        private void drawingBox_Paint(object sender, PaintEventArgs e)
        {
            PaintDrawingBox();
            ResizeDrawingBox();
        }
    }
}
