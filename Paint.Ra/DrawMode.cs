using System;
using System.Windows.Forms;

namespace Paint.Ra
{
    internal sealed partial class Canvas : PictureBox
    {
        public enum DrawMode
        {
            Line, Brush, Pen, Wrap,Elipse,Rectangle,ClickLine,RightAngleTriangle,Triangle,Diamond,Text
        }
        public DrawMode SelectedDrawMode;
        
        public delegate void Smc(object sender, EventArgs e);
        public new event Smc SizeModeChanged = delegate{ };

        #region Draw Mode Control

        public void SetMode(DrawMode mode)
        {
            SelectedDrawMode = mode;
            switch (mode)
            {
                case DrawMode.Line:
                    ResetSizeModeSettings();
                    Line(true);
                    break;
                case DrawMode.ClickLine:
                    ResetSizeModeSettings();
                    _isJoinLine = true;
                    Line(true);
                    break;
                case DrawMode.Brush:
                    ResetSizeModeSettings();
                    Brush(true);
                    break;
                case DrawMode.Wrap:
                    ResetSizeModeSettings();
                    Brush(true);
                    _pen = true;
                    _wrap = true;
                    break;
                case DrawMode.Pen:
                    ResetSizeModeSettings();
                    Brush(true);
                    _pen = true;
                    break;
                case DrawMode.Elipse:
                    ResetSizeModeSettings();
                    _chosenShapeType = ShapeType.Elipse;
                    Shape(true);
                    break;
                case DrawMode.Rectangle:
                    ResetSizeModeSettings();
                    _chosenShapeType = ShapeType.Rectangle;
                    Shape(true);
                    break;
                case DrawMode.RightAngleTriangle:
                    ResetSizeModeSettings();
                    _chosenShapeType = ShapeType.RightAngleTriangle;
                    Shape(true);
                    break;
                case DrawMode.Triangle:
                    ResetSizeModeSettings();
                    _chosenShapeType = ShapeType.Triangle;
                    Shape(true);
                    break;
                case DrawMode.Diamond:
                    ResetSizeModeSettings();
                    _chosenShapeType = ShapeType.Diamond;
                    Shape(true);
                    break;
                case DrawMode.Text:
                    ResetSizeModeSettings();
                    Text(true);
                    break;
                default:
                    MessageBox.Show(@"Invalid Draw Mode");
                    break;
            }
            SizeModeChanged(this, new EventArgs());
        }
        
        private void ResetSizeModeSettings()
        {
            Line(false);
            Brush(false);
            Shape(false);
            Text(false);
            _wrap = false;
            _pen = false;
        }

        #endregion

        private new void Text(bool add)
        {
            if (add) goto AddElements;

            MouseUp -= TextDrawRelease;
            MouseDown -= TextHoldDown;

            return;

            AddElements:
            _wrap = false;
            _pen = false;
            MouseUp += TextDrawRelease;
            MouseDown += TextHoldDown;
        }

        #region ShapeMode

        private void Shape(bool add)
        {
            if (add) goto AddElements;

            MouseUp -= ShapeDrawRelease;
            MouseDown -= ShapeHoldDown;

            return;

            AddElements:
            _wrap = false;
            _pen = false;
            MouseUp += ShapeDrawRelease;
            MouseDown += ShapeHoldDown;
        }

        #endregion

        #region Line Mode


        private void Line(bool add)
        {
            if (add) goto AddElements;

            MouseUp -= LineDrawRelease;
            MouseDown -= LineHoldDown;
            _isJoinLine = false;

            return;

            AddElements:
            _wrap = false;
            _pen = false;
            MouseUp += LineDrawRelease;
            MouseDown += LineHoldDown;
        }

        

        #endregion

        #region Brush Mode

        private void Brush(bool add)
        {
            if (add) goto AddElements;

            MouseMove -= DrawBrushSpots;
            MouseUp -= Brush_MouseUp;
            return;

            AddElements:
            MouseMove += DrawBrushSpots;
            MouseUp += Brush_MouseUp;
        }

        #endregion
    }
}