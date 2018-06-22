using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint.Ra
{
    internal sealed partial class Canvas
    {
        private enum ShapeType
        {
            Elipse,Rectangle, RightAngleTriangle,Triangle,Diamond
        }

        private ShapeType _chosenShapeType = ShapeType.Rectangle;

        private void DrawShape()
        {
            var targetBitmap = Image != null ? new Bitmap(Image, ClientSize.Width, ClientSize.Height) : new Bitmap(ClientSize.Width, ClientSize.Height);

            using (new Bitmap(Image != null ? Image.Width : ClientSize.Width, Image != null ? Image.Width : ClientSize.Height))
            {
                using (var backGraphics = Graphics.FromImage(targetBitmap))
                    if (!Fill)
                        DrawShape(backGraphics);
                    else
                        FillShape(backGraphics);
            }
            AddAction(targetBitmap);
            _index = _actions.Count - 1;
            Image = targetBitmap;
        }

        #region Shape Draw

        private void DrawShape(Graphics backgroundGraphics)
        {
            var a = new Pen(CurrentColour, LineSize)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round
            };
            switch (_chosenShapeType)
            {
                case ShapeType.Elipse:
                    backgroundGraphics.DrawEllipse(a, GetRectangle());
                    break;
                case ShapeType.Rectangle:
                    backgroundGraphics.DrawRectangle(a, GetRectangle());

                    break;
                case ShapeType.RightAngleTriangle:
                    var triangle = new[]{_firstLocation,_lastLocation,new Point(_firstLocation.X, _lastLocation.Y)};
                    backgroundGraphics.DrawPolygon(a, triangle);
                    break;
                case ShapeType.Triangle:
                    //g.DrawRectangle(a, getRectangle());
                    var t = new Point[3];
                    t[1] = _lastLocation;
                    t[2] = new Point(_firstLocation.X, _lastLocation.Y);
                    t[0] = new Point((t[1].X + t[2].X) / 2, _firstLocation.Y);
                    backgroundGraphics.DrawPolygon(a, t);
                    break;
                case ShapeType.Diamond:
                    //g.DrawRectangle(a, getRectangle());
                    var d = new Point[4];
                    d[0] = new Point((_firstLocation.X + _lastLocation.X) / 2, _firstLocation.Y);
                    d[3] = new Point((_firstLocation.X + _lastLocation.X) / 2, _lastLocation.Y);
                    d[1] = new Point(_firstLocation.X, (_firstLocation.Y + _lastLocation.Y) / 2);
                    d[2] = new Point(_lastLocation.X, (_firstLocation.Y + _lastLocation.Y) / 2);
                    backgroundGraphics.SmoothingMode = SmoothingMode.HighQuality;

                    // g.DrawPolygon(a, d);
                    backgroundGraphics.DrawLine(a, d[0], d[1]);
                    backgroundGraphics.DrawLine(a, d[1], d[3]);
                    backgroundGraphics.DrawLine(a, d[3], d[2]);
                    backgroundGraphics.DrawLine(a, d[2], d[0]);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void FillShape(Graphics backgroundGrapics)
        {
            var a = new SolidBrush(CurrentColour);
            switch (_chosenShapeType)
            {
                case ShapeType.Elipse:
                    backgroundGrapics.FillEllipse(a, GetRectangle());
                    break;
                case ShapeType.Rectangle:
                    backgroundGrapics.FillRectangle(a, GetRectangle());
                    break;
                case ShapeType.RightAngleTriangle:
                    //g.DrawRectangle(a, getRectangle());
                    var triangle = new[]{_firstLocation,_lastLocation,new Point(_firstLocation.X, _lastLocation.Y)};
                    backgroundGrapics.FillPolygon(a, triangle);
                    break;
                case ShapeType.Triangle:
                    var t = new Point[3];
                    t[1] = _lastLocation;
                    t[2] = new Point(_firstLocation.X, _lastLocation.Y);
                    t[0] = new Point((t[1].X + t[2].X) / 2, _firstLocation.Y);
                    backgroundGrapics.FillPolygon(a, t);
                    break;
                case ShapeType.Diamond:
                    //g.DrawRectangle(a, getRectangle());
                    var d = new Point[4];
                    d[0] = new Point((_firstLocation.X + _lastLocation.X) / 2, _firstLocation.Y);
                    d[3] = new Point((_firstLocation.X + _lastLocation.X) / 2, _lastLocation.Y);
                    d[1] = new Point(_firstLocation.X, (_firstLocation.Y + _lastLocation.Y) / 2);
                    d[2] = new Point(_lastLocation.X, (_firstLocation.Y + _lastLocation.Y) / 2);
                    backgroundGrapics.SmoothingMode = SmoothingMode.HighQuality;
                    var aa = new Pen(CurrentColour, LineSize);
                    aa.StartCap = LineCap.Round;
                    aa.EndCap = LineCap.Round;
                    
                    _gpath = new GraphicsPath();
                    backgroundGrapics.DrawLine(aa, d[0], d[1]);
                    _gpath.AddLine(d[0], d[1]);

                    backgroundGrapics.DrawLine(aa, d[1], d[3]);
                    _gpath.AddLine(d[1], d[3]);

                    backgroundGrapics.DrawLine(aa, d[3], d[2]);
                    _gpath.AddLine(d[3], d[2]);

                    backgroundGrapics.DrawLine(aa, d[2], d[0]);
                    _gpath.AddLine(d[2], d[0]);

                    backgroundGrapics.FillPath(a, _gpath);

                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        #region Mouse Events

        private void ShapeDrawRelease(object sender, MouseEventArgs e)
        {
            _lastLocation = _mousePosition;
            DrawShape();
            //background = new Bitmap(Width,Height,g);
            _currentlyDrawing = false;
        }

        private void ShapeHoldDown(object sender, MouseEventArgs e)
        {
            _firstLocation = _mousePosition;
            _currentlyDrawing = !_currentlyDrawing || _currentlyDrawing;
            //draw.Start();
        }

        #endregion
    }
}
