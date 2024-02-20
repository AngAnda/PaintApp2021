using Paint.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    internal class CanvasManager
    {
        private Bitmap canvasBitmap;
        private ITool currentTool;

        public CanvasManager(int width, int height)
        {
            canvasBitmap = new Bitmap(width, height);

        }

        public void SetTool(ITool tool)
        {
            currentTool = tool;
        }

        public void Draw(Point position)
        {
            if (currentTool != null)
            {
                using (Graphics g = Graphics.FromImage(canvasBitmap))
                {
                    //currentTool.UseTool(g, ); // Completare cu parametri necesari
                }
            }
        }
    }
}
