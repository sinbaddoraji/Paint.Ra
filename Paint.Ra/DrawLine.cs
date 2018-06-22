using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint.Ra
{
    internal sealed partial class Canvas
    {
        private LineCap _lineStart = LineCap.Flat;
        private LineCap _lineEnd = LineCap.Flat;
        
        private void DrawLine()
        {
            var a = new Pen(CurrentColour, LineSize){StartCap = _lineStart,EndCap = _lineEnd};

            var targetBitmap = Image != null ? new Bitmap(Image, ClientSize.Width, ClientSize.Height) : new Bitmap(ClientSize.Width, ClientSize.Height);

            using (new Bitmap(ClientSize.Width, ClientSize.Height))
            {
                using (var backgroundGraphics = Graphics.FromImage(targetBitmap))
                {
                    backgroundGraphics.SmoothingMode = SmoothingMode.HighQuality;
                    backgroundGraphics.DrawLine(a, _firstLocation, _lastLocation);
                }
            }
            AddAction(targetBitmap);
            Image = targetBitmap;
        }

        #region Mouse Events

         private void LineDrawRelease(object sender, MouseEventArgs e)
        {
            if (_isJoinLine)
            {
                DrawLine();
                _firstLocation = _lastLocation;
            }
            else
            {
                _lastLocation = _mousePosition;
                DrawLine();
            }
            _currentlyDrawing = false;
        }

        private void LineHoldDown(object sender, MouseEventArgs e)
        {
            _currentlyDrawing = !_currentlyDrawing || _currentlyDrawing;
            if(_isJoinLine == false)
            {
                _firstLocation = _mousePosition;
            }
        }

        #endregion
       
        
    }
}