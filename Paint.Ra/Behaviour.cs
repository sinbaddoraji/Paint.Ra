using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Paint.Ra
{
    internal sealed partial class Canvas
    {
        #region Undo Redo

        public void Undo()
        {
            //Undo Image Action
            try
            {
                _index--;
                Image = _actions[_index];
                
            }
            catch{ }
        }
        public void Redo()
        {
            //Redo Image Action
            try
            {
                _index++;
                Image = _actions[_index];
            }
            catch{ }
        }
        
        #endregion

        #region Image Control

        private void DrawBackground(Color backcolour)
        {
            //Draw background of canvas image
            _background = new Bitmap(Width, Height);
            var g = Graphics.FromImage(_background);

            //Draw background
            g.FillRectangle(new SolidBrush(backcolour), 0, 0, Width, Height);

            //Add background to image actions and set background as the canvas's image
            _actions.Add(_background);
            Image = _background;
        }
        private void AddAction(Image i)
        {
            //Add Image to the list of images that act as actions
            _index++;
            if (_index == 0)
            {
                _actions.Clear();
            }
            _actions.Add(i);
        }
        
        #endregion

        #region Set Line Anchor

        public void SetLineAk(LineCap l,bool end)
        {
            if(end)_lineEnd = l;
            else _lineStart = l;
        }

        #endregion

        #region Common mouse controls

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            CurrentColour = e.Button == MouseButtons.Left ? ColourA : ColourB;
            if (_wrap) _firstLocation = _mousePosition;
            _lastLocation = _mousePosition;
            _currentlyDrawing = !_currentlyDrawing || _currentlyDrawing;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            _currentlyDrawing = false;
            //points.Clear();
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            _mousePosition = new Point(e.X, e.Y);
        }

        #endregion

    }
}
