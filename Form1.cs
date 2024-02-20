using Paint.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {

        bool choose, PenOn;
        Color col = Color.AliceBlue;
        int brushSize = 15;
  
        Bitmap bmp;
        ITool tool;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            choose = false;
            tool = new PenTool(brushSize);
            AlphaTB.Value = 255;
           
            PenOn = false;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            whiteBmp();
            updateColor();
            
        }

        public void updateColor()
        {
            col = Color.FromArgb(RedTB.Value, GreenTB.Value, BlueTB.Value);
            pictureBox3.BackColor = col;
            RedL.Text = "R: " + col.R.ToString();
            BlueL.Text = "B: " + col.B.ToString();
            GreenL.Text = "G: " + col.G.ToString();
            AlphaL.Text = "A: " + col.A.ToString();
        }


        #region ColorPicker
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            updateColor();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            choose = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (choose && e.X >= 0 && e.Y >= 0 && e.X <= this.Width && e.Y >= this.Height)
            {
                col = bmp.GetPixel(e.X, e.Y);

                RedTB.Value = col.R;
                BlueTB.Value = col.B;
                GreenTB.Value = col.G;
                AlphaTB.Value = col.A;
                RedL.Text = "R: " + col.R.ToString();
                BlueL.Text = "B: " + col.B.ToString();
                GreenL.Text = "G: " + col.G.ToString();
                AlphaL.Text = "A: " + col.A.ToString();
                pictureBox3.BackColor = col;
                updateColor();
            }
        }

        private void BlueTB_Scroll(object sender, EventArgs e)
        {
            updateColor();
        }

        private void GreenTB_Scroll(object sender, EventArgs e)
        {
            updateColor();
        }

        private void AlphaTB_Scroll(object sender, EventArgs e)
        {
            updateColor();
        }

        private void RedTB_ValueChanged(object sender, EventArgs e)
        {
            updateColor();
        }


        private void Penbt_Click(object sender, EventArgs e)
        {
            tool = new PenTool(brushSize);
        }

        private void LineBT_Click(object sender, EventArgs e)
        {
           tool = new EraseTool(brushSize);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

            textBox1.Text = brushSize.ToString();
        }

        public void draw(int x, int y)
        {
            if (PenOn)
            {
                Graphics g = Graphics.FromImage(bmp);
                
                tool.UseTool(g, col, new Point(x, y), brushSize);
                pictureBox1.Image = bmp;

            }
        }

        public void whiteBmp()
        {
            using (Graphics gf = Graphics.FromImage(bmp))

            {
                pictureBox1.Image = bmp;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTextBox1.Text = "X: " + e.X.ToString() + "   Y: " + e.Y.ToString();
            draw(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            PenOn = false;
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Images|*.png;*.bmp;*.jpg";
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveDialog.FileName, ImageFormat.Bmp);
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.RestoreDirectory = true;
            of.Filter = "Image|*.png;*.bmp;*.jpg";
            if (of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(of.FileName);
                bmp = (Bitmap)pictureBox1.Image;
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //https://www.c-sharpcorner.com/article/colordialog-in-C-Sharp/
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                col = cd.Color;
                RedTB.Value = col.R;
                BlueTB.Value = col.B;
                GreenTB.Value = col.G;
                AlphaTB.Value = col.A;
                updateColor();
            }

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            brushSize = (int)numericUpDown1.Value;
        }

        private void newCanvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            whiteBmp();
            pictureBox1.Image = bmp;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PenOn = true;
        }


        #endregion 
    }
}
