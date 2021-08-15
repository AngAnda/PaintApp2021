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

        #region Variables
        bool choose, PenOn;
        Color col = Color.AliceBlue;
        int brushSize = 1;
        SolidBrush b, bw;
        enum Tool
        {
            Pen, Eraser, 
        };
        Tool tool;
        Bitmap bmp;
        #endregion Variables

        #region To do

        /// <summary>
        /// Documentation of the project (write in Notion about DialogBox, Color dialog)
        /// Embed a color dialog in the project and understantd how it works
        /// https://www.c-sharpcorner.com/article/colordialog-in-C-Sharp/
        /// https://docs.microsoft.com/en-us/windows/win32/dlgbox/color-dialog-box
        /// </summary>
        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            choose = false;
            tool = Tool.Pen;
            AlphaTB.Value = 255;
            b = new SolidBrush(col);
            bw = new SolidBrush(Color.White);
            PenOn = false;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            whiteBmp();
            updateColor();
            vScrollBar1.Value = brushSize = 3;
            pictureBox4.Invalidate();
            textBox1.Text = vScrollBar1.Value.ToString();
        }

        public void updateColor()
        {
            col = Color.FromArgb(RedTB.Value, GreenTB.Value, BlueTB.Value);
            pictureBox3.BackColor = col;
            RedL.Text = "R: " + col.R.ToString();
            BlueL.Text = "B: " + col.B.ToString();
            GreenL.Text = "G: " + col.G.ToString();
            AlphaL.Text = "A: " + col.A.ToString();
            b = new SolidBrush(col);
            pictureBox4.Invalidate();
           // Graphics g2 = pictureBox4.CreateGraphics();
          
            /*if(tool == Tool.Pen)
                g2.FillEllipse(b, pictureBox4.Width / 2 - brushSize / 2, pictureBox4.Height / 2 - brushSize / 2, brushSize, brushSize);*/
            //b = new SolidBrush(col);
        }


        #region ColorPicker
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            updateColor();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            choose = true;
            //Bitmap bmp = (Bitmap)pictureBox2.Image.Clone();
            col = ((Bitmap)pictureBox2.Image).GetPixel(e.X, e.Y);
            RedTB.Value = col.R;
            BlueTB.Value = col.B;
            GreenTB.Value = col.G;
            AlphaTB.Value = col.A;
            /*
            RedL.Text = "R: " + col.R.ToString();
            BlueL.Text = "B: " + col.B.ToString();
            GreenL.Text = "G: " + col.G.ToString();
            AlphaL.Text = "A: " + col.A.ToString();*/
            updateColor();
            //pictureBox3.BackColor = col;
        }

     
        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            choose = false;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (choose && e.X>=0 && e.Y>=0 && e.X<=this.Width && e.Y>=this.Height)
            {
                Bitmap bmp = (Bitmap)pictureBox2.Image.Clone();
                col = bmp.GetPixel(e.X, e.Y);
                if (col != pictureBox2.BackColor)
                {
                    
                    RedTB.Value = col.R;
                    BlueTB.Value = col.B;
                    GreenTB.Value = col.G;
                    AlphaTB.Value = col.A;/*
                    RedL.Text = "R: " + col.R.ToString();
                    BlueL.Text = "B: " + col.B.ToString();
                    GreenL.Text = "G: " + col.G.ToString();
                    AlphaL.Text = "A: " + col.A.ToString();
                    pictureBox3.BackColor = col;*/
                    updateColor();
                }
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

      
        #endregion

        #region Menu
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void xToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region PenSize
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }



        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void Penbt_Click(object sender, EventArgs e)
        {
            tool = Tool.Pen;
            pictureBox4.Invalidate();
        }

        private void LineBT_Click(object sender, EventArgs e)
        {
            tool = Tool.Eraser;
            pictureBox4.Invalidate();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
            brushSize = vScrollBar1.Value;
            textBox1.Text = brushSize.ToString();
            b = new SolidBrush(col);
            // pictureBox4.Invalidate();
             pictureBox4.Invalidate();
            /*Graphics pb3 = pictureBox4.CreateGraphics();
             pb3.FillEllipse(b ,pictureBox4.Width/2 - brushSize/2, pictureBox4.Height/2-brushSize/2, brushSize, brushSize);*/
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {

            switch(tool)
            {
                case Tool.Pen: e.Graphics.FillEllipse(b, pictureBox4.Width / 2 - brushSize / 2, pictureBox4.Height / 2 - brushSize / 2, brushSize, brushSize); break;
                case Tool.Eraser: e.Graphics.FillEllipse(bw, pictureBox4.Width / 2 - brushSize / 2, pictureBox4.Height / 2 - brushSize / 2, brushSize, brushSize); break;
            }

            if(tool == Tool.Pen)
            e.Graphics.FillEllipse(b, pictureBox4.Width / 2 - brushSize/2, pictureBox4.Height / 2 - brushSize/2, brushSize, brushSize);

        }

        #endregion


        #region Canvas

        public void draw(int x, int y)
        {
            if (PenOn)
            {
                Graphics g = Graphics.FromImage(bmp);

                switch (tool)
                {
                    case Tool.Pen:
                        g.FillEllipse(b, x - brushSize / 2, y - brushSize / 2, brushSize, brushSize);
                        pictureBox1.Image = bmp; break;
                    case Tool.Eraser:
                        g.FillEllipse(bw, x - brushSize / 2, y - brushSize / 2, brushSize, brushSize);
                        pictureBox1.Image = bmp; break;
                }
                pictureBox1.Image = bmp;

            }
        }

        public void whiteBmp()
        {
            using(Graphics gf = Graphics.FromImage(bmp))
            
            {
                gf.FillRectangle(bw, 0, 0, bmp.Width, bmp.Height);
                pictureBox1.Image = bmp;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTextBox1.Text = "X: " + e.X.ToString() + "   Y: " + e.Y.ToString();
            draw(e.X, e.Y);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
          
            
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
            if(saveDialog.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(saveDialog.FileName, ImageFormat.Bmp); 
            }
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.RestoreDirectory = true ;
            of.Filter = "Image|*.png;*.bmp;*.jpg";
            if( of.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(of.FileName);
                bmp = (Bitmap)pictureBox1.Image;
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //https://www.c-sharpcorner.com/article/colordialog-in-C-Sharp/
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            if( cd.ShowDialog() == DialogResult.OK)
            {
                col = cd.Color;
                RedTB.Value = col.R;
                BlueTB.Value = col.B;
                GreenTB.Value = col.G;
                AlphaTB.Value = col.A;
                updateColor();
            }

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
