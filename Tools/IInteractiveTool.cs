﻿
namespace Paint.Tools
{
    internal interface IInteractiveTool
    {
        bool ColorCanChange { get; }

        int BrushSize { get; set; }


    }
}
