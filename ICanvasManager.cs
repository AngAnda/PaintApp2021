using Paint.Tools;
using System.Drawing;
using System.Drawing.Imaging;

namespace Paint
{
    internal interface ICanvasManager
    {
        void ClearCanvas(Color clearColor = default);
        void DrawOnCanvas(ITool tool, Color color, Point point, int size);
        Color GetColorFromPixel(int x, int y);
        void LoadCanvas(string filePath);
        void SaveCanvas(string filePath, ImageFormat format);
    }
}