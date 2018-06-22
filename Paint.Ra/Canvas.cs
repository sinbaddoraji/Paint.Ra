using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Paint.Ra
{
    internal sealed partial class Canvas
    {
        private bool _currentlyDrawing;//Currently drawing on canvas or not

        private Bitmap _background;

        private Point _firstLocation;//Mouse location before click
        private Point _lastLocation;//Mouse location after click
        public Point _mousePosition;
        
        public int LineSize = 6;
        public int BrushWidth = 5;
        public int PenSize = 3;

        public Color ColourA = Color.Black;
        public Color ColourB = Color.White;
        public Color CurrentColour = Color.Black;

        private bool _isJoinLine;
        public bool Fill = false;

        private readonly List<Image> _actions = new List<Image>();

        
        private bool _wrap;
        private bool _pen;
        
        private int _index;
        
        GraphicsPath _gpath = new GraphicsPath();
        
        private Rectangle GetRectangle() => new Rectangle(
            Math.Min(_firstLocation.X, _lastLocation.X),
            Math.Min(_firstLocation.Y, _lastLocation.Y),
            Math.Abs(_firstLocation.X - _lastLocation.X),
            Math.Abs(_firstLocation.Y - _lastLocation.Y));
        

        public Canvas()
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            SelectedDrawMode = DrawMode.Brush;

            BackColor = Color.White;

            Size = new Size(913, 508);

            DrawBackground(BackColor);
            

            MouseMove += Canvas_MouseMove;

            MouseUp += Canvas_MouseUp;

            MouseDown += Canvas_MouseDown;

            
        }





    }
}