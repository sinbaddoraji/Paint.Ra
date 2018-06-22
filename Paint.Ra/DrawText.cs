using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Ra
{
    internal sealed partial class Canvas
    {
        public string textToDraw = "Kim";
        public Font currentFont;
        private void DrawText()
        {
            var targetBitmap = Image != null ? new Bitmap(Image, ClientSize.Width, ClientSize.Height) : new Bitmap(ClientSize.Width, ClientSize.Height);

            using (new Bitmap(Image != null ? Image.Width : ClientSize.Width, Image != null ? Image.Width : ClientSize.Height))
            {
                using (var backGraphics = Graphics.FromImage(targetBitmap))
                {
                    var rect = GetRectangle();
                    var DrawStringSize = backGraphics.MeasureString(textToDraw, currentFont);
                    var YOffset = (rect.Height - DrawStringSize.Height) / 2;
                    var XOffset = ((rect.Width) - (DrawStringSize.Width)) / 2;
                    var TextRect = new RectangleF(rect.X + XOffset, rect.Y + YOffset, DrawStringSize.Width, DrawStringSize.Height);
                    var drawFormat = new StringFormat();
                    drawFormat.Alignment = StringAlignment.Center;
                    backGraphics.DrawString(textToDraw, currentFont, new SolidBrush(CurrentColour), TextRect, drawFormat);
                    //backGraphics.DrawString(textToDraw, currentFont, new SolidBrush(CurrentColour),(_firstLocation.X + _lastLocation.X)/2,(_firstLocation.X + _lastLocation.X) / 2);
                }
            }
            AddAction(targetBitmap);
            _index = _actions.Count - 1;
            Image = targetBitmap;
        }
        #region Mouse Events

        private void TextDrawRelease(object sender, MouseEventArgs e)
        {
            _lastLocation = _mousePosition;
            DrawText();
            //background = new Bitmap(Width,Height,g);
            _currentlyDrawing = false;
        }

        private void TextHoldDown(object sender, MouseEventArgs e)
        {
            _firstLocation = _mousePosition;
            _currentlyDrawing = !_currentlyDrawing || _currentlyDrawing;
            //draw.Start();
        }

        #endregion

    }
}
