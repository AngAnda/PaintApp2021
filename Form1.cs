using Paint.Tools;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {

        private IColorManager colorManager;
        private ICanvasManager canvasManager;
        private ToolState toolState;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorManager = new ColorManager();
            canvasManager = new CanvasManager(pictureBox1);
            toolState = new ToolState(15);
            toolState.CurrentTool = new PenTool(toolState.BrushSize);

            AlphaTB.Value = 255;

            UpdateColorDisplay(colorManager);

        }

        private void UpdateColorDisplay(IColorManager colorManager)
        {
            pictureBox3.BackColor = colorManager.CurrentColor;
            RedL.Text = "R: " + colorManager.Red;
            BlueL.Text = "B: " + colorManager.Blue;
            GreenL.Text = "G: " + colorManager.Green;
            AlphaL.Text = "A: " + colorManager.Alpha;
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateColorDisplay(colorManager);
        }

        private void PictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X >= 0 && e.Y >= 0 && e.X <= this.Width && e.Y >= this.Height)
            {
                Color col = canvasManager.GetColorFromPixel(e.X, e.Y);
                colorManager.UpdateColor(col);
                UpdateColorDisplay(colorManager);
            }
        }

        private void BlueTB_Scroll(object sender, EventArgs e)
        {

            UpdateColorDisplay(colorManager);
        }

        private void GreenTB_Scroll(object sender, EventArgs e)
        {
            colorManager.UpdateColor(RedTB.Value, GreenTB.Value, BlueTB.Value, AlphaTB.Value);
            UpdateColorDisplay(colorManager);
        }

        private void AlphaTB_Scroll(object sender, EventArgs e)
        {
            colorManager.UpdateColor(RedTB.Value, GreenTB.Value, BlueTB.Value, AlphaTB.Value);

            UpdateColorDisplay(colorManager);
        }

        private void RedTB_ValueChanged(object sender, EventArgs e)
        {
            colorManager.UpdateColor(RedTB.Value, GreenTB.Value, BlueTB.Value, AlphaTB.Value);

            UpdateColorDisplay(colorManager);
        }


        private void Penbt_Click(object sender, EventArgs e)
        {
            toolState.CurrentTool = new PenTool(toolState.BrushSize);
        }

        private void LineBT_Click(object sender, EventArgs e)
        {
            toolState.CurrentTool = new EraseTool(toolState.BrushSize);
        }

        private void VScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = toolState.BrushSize.ToString();
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripTextBox1.Text = "X: " + e.X.ToString() + "   Y: " + e.Y.ToString();
            if (toolState.IsActive)
                canvasManager.DrawOnCanvas(toolState.CurrentTool, colorManager.CurrentColor, e.Location, toolState.BrushSize);
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            toolState.IsActive = false;
        }

        private void SaveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Images|*.png;*.bmp;*.jpg",
                RestoreDirectory = true
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                canvasManager.SaveCanvas(saveDialog.FileName, ImageFormat.Bmp);
            }
        }

        private void ImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog
            {
                RestoreDirectory = true,
                Filter = "Image|*.png;*.bmp;*.jpg"
            };

            if (of.ShowDialog() == DialogResult.OK)
            {
                canvasManager.LoadCanvas(of.FileName);
            }

        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                colorManager.UpdateColor(cd.Color);
                RedTB.Value = colorManager.RedValue;
                BlueTB.Value = colorManager.BlueValue;
                GreenTB.Value = colorManager.GreenValue;
                AlphaTB.Value = colorManager.AlphaValue;
                UpdateColorDisplay(colorManager);
            }
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            toolState.BrushSize = (int)numericUpDown1.Value;
        }

        private void NewCanvasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            canvasManager.ClearCanvas();
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            toolState.IsActive = true;
        }

    }
}
