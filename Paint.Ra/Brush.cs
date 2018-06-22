using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint.Ra
{
    internal sealed partial class Canvas
    {
        private void BrushDraw()
        {
            var targetBitmap = Image != null ? new Bitmap(Image, ClientSize.Width, ClientSize.Height) : new Bitmap(ClientSize.Width, ClientSize.Height);

            using (new Bitmap(Image != null ? Image.Width : ClientSize.Width, Image != null ? Image.Width : ClientSize.Height))
            {
                using (var backgroundGraphs = Graphics.FromImage(targetBitmap))
                {
                    var gra = new Pen(CurrentColour,_pen ? PenSize : BrushWidth)
                    {
                        StartCap = LineCap.Round,
                        EndCap = LineCap.Round
                    };
                    
                    backgroundGraphs.SmoothingMode = SmoothingMode.HighQuality;
                    
                    backgroundGraphs.DrawLine(gra, _wrap ? _firstLocation : _lastLocation, _mousePosition);
                }
            }

            _index = _actions.Count - 1;
            Image = targetBitmap;
        }

        #region Mouse Events

        private void DrawBrushSpots(object sender, MouseEventArgs e)
        {
            //MouseMove
            if (!_currentlyDrawing) return;
            BrushDraw();
            if(_wrap ==false)_firstLocation = _lastLocation;

            _lastLocation = _mousePosition;
            
        }

        private void Brush_MouseUp(object sender, MouseEventArgs e)
        {
            AddAction(Image);
            _currentlyDrawing = false;
        }

        #endregion
       
    }
}