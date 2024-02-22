using System.Drawing;


namespace Paint.Tools
{
    internal interface ITool
    {
        void UseTool(Graphics canvas, Color color, Point position, int size);
    }
}
