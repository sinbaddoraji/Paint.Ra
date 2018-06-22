using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Paint.Ra
{
    public partial class Form1 : Form
    {
        private readonly string[] _penSizes;
        private readonly object[] _otherSizes;

        private List<int> Xs = new List<int>();
        private List<int> Ys = new List<int>();
        public Form1()
        {
            InitializeComponent();

            _penSizes = Enumerable.Range(1,4).Select(x => x.ToString()).ToArray();
            
            var a = new List<string>();
            for (var i = 1; i < 10; i++) { a.Add(i.ToString()); }
            for (var i = 10; i < 70; i+=5) { a.Add(i.ToString()); }
            _otherSizes = a.ToArray();
            
            timer1.Start();
            radioButton3.Checked = true;
            canvas1.currentFont = Font;

            
        }

        private void Undo(object sender, EventArgs e) => canvas1.Undo();

        private void Redo(object sender, EventArgs e) => canvas1.Redo();


        private void LineModeSelect(object sender, EventArgs e) => canvas1.SetMode(Canvas.DrawMode.Line);

        private void BrushModeSelect(object sender, EventArgs e) => canvas1.SetMode(Canvas.DrawMode.Brush);

        private void PenModeSelect(object sender, EventArgs e) => canvas1.SetMode(Canvas.DrawMode.Pen);

        private void WrapModeSelect(object sender, EventArgs e) => canvas1.SetMode(Canvas.DrawMode.Wrap);

        private void RectangleModeSelect(object sender, EventArgs e) => canvas1.SetMode(Canvas.DrawMode.Rectangle);

        private void ElipseModeSelect(object sender, EventArgs e) => canvas1.SetMode(Canvas.DrawMode.Elipse);

        private void ClickLineModeSelect(object sender, EventArgs e) => canvas1.SetMode(Canvas.DrawMode.ClickLine);

        private void RightAngledTriangleModeSelect(object sender, EventArgs e) => canvas1.SetMode(Canvas.DrawMode.RightAngleTriangle);

        private void TriangleModeSelect(object sender, EventArgs e) => canvas1.SetMode(Canvas.DrawMode.Triangle);

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            canvas1.SetMode(Canvas.DrawMode.Diamond);
        }
        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            canvas1.SetMode(Canvas.DrawMode.Text);
            canvas1.textToDraw = textBox1.Text;
        }

        private void ColourAPick(object sender, EventArgs e)
        {
            if(usualSizes.ShowDialog() == DialogResult.OK)
            {
                panel2.BackColor = usualSizes.Color;
            }
        }
        private void panel2_BackColorChanged(object sender, EventArgs e)
        {
            canvas1.ColourA = panel2.BackColor;
        }

        private void ColourBPick(object sender, EventArgs e)
        {
            if (b.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = b.Color;
            }
        }

        private void panel1_BackColorChanged(object sender, EventArgs e)
        {
            canvas1.ColourB = panel1.BackColor;
        }


        private Point _fitstLocation;      // mouse-down position
        private Point _lastlocation;    // current mouse position
        private bool _isdrawing;        // busy drawing

        private readonly List<Rectangle> _rectangles = new List<Rectangle>();  // previous rectangles

        private Rectangle GetRectangle() => new Rectangle(
            Math.Min(_fitstLocation.X, _lastlocation.X),
            Math.Min(_fitstLocation.Y, _lastlocation.Y),
            Math.Abs(_fitstLocation.X - _lastlocation.X),
            Math.Abs(_fitstLocation.Y - _lastlocation.Y));

        private bool Shape()
        {
            return canvas1.SelectedDrawMode == Canvas.DrawMode.Rectangle
                || canvas1.SelectedDrawMode == Canvas.DrawMode.Elipse
                || canvas1.SelectedDrawMode == Canvas.DrawMode.Line
                || canvas1.SelectedDrawMode == Canvas.DrawMode.RightAngleTriangle
                || canvas1.SelectedDrawMode == Canvas.DrawMode.Triangle
                || canvas1.SelectedDrawMode == Canvas.DrawMode.Diamond
            || canvas1.SelectedDrawMode == Canvas.DrawMode.Text;
        }
        private void canvas1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!Shape()) return;
            _lastlocation = _fitstLocation = e.Location;
            _isdrawing = true;
        }

        private void canvas1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Invalidate();
            pictureBox2.Invalidate();
            pictureBox3.Invalidate();
            pictureBox4.Invalidate();
            if (!Shape()) return;
            _lastlocation = e.Location;
            if (_isdrawing) canvas1.Invalidate();
            
            
        }

        private void canvas1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Shape())
            {
                if (_isdrawing)
                {
                    _isdrawing = false;
                    var rc = GetRectangle();
                    if (rc.Width > 0 && rc.Height > 0) _rectangles.Add(rc);
                    canvas1.Invalidate();
                }
            }
            pictureBox1.Invalidate();
        }

        private void canvas1_Paint(object sender, PaintEventArgs e)
        {
            

            if (_isdrawing)
            {
                if (canvas1.SelectedDrawMode == Canvas.DrawMode.Elipse)
                {
                    e.Graphics.DrawEllipse(new Pen(new SolidBrush(canvas1.CurrentColour), canvas1.BrushWidth), GetRectangle());
                }
                else if (canvas1.SelectedDrawMode == Canvas.DrawMode.Line)
                {
                    e.Graphics.DrawLine(new Pen(new SolidBrush(canvas1.CurrentColour), canvas1.LineSize),_fitstLocation,_lastlocation);
                }
                else if(canvas1.SelectedDrawMode == Canvas.DrawMode.Rectangle)
                {
                    e.Graphics.DrawRectangle(new Pen(new SolidBrush(canvas1.CurrentColour), canvas1.BrushWidth), GetRectangle());
                }
                else if (canvas1.SelectedDrawMode == Canvas.DrawMode.Text)
                {
                    e.Graphics.DrawRectangle(new Pen(new SolidBrush(canvas1.CurrentColour), canvas1.BrushWidth), GetRectangle());
                    var rect = GetRectangle();
                    var DrawStringSize = e.Graphics.MeasureString(canvas1.textToDraw, canvas1.currentFont);
                    var YOffset = (rect.Height - DrawStringSize.Height) / 2;
                    var XOffset = ((rect.Width) - (DrawStringSize.Width)) / 2;
                    var TextRect = new RectangleF(rect.X + XOffset, rect.Y + YOffset, DrawStringSize.Width, DrawStringSize.Height);
                    var drawFormat = new StringFormat();
                    drawFormat.Alignment = StringAlignment.Center;
                    e.Graphics.DrawString(canvas1.textToDraw, canvas1.currentFont, new SolidBrush(canvas1.CurrentColour), TextRect, drawFormat);
                }
                else if (canvas1.SelectedDrawMode == Canvas.DrawMode.RightAngleTriangle)
                {
                    Point[] triangle = new Point[3];
                    triangle[0] = _fitstLocation;
                    triangle[1] = _lastlocation;
                    triangle[2] = new Point(_fitstLocation.X, _lastlocation.Y);
                    
                    e.Graphics.DrawPolygon(new Pen(new SolidBrush(canvas1.CurrentColour), canvas1.BrushWidth), triangle);
                }
                else if (canvas1.SelectedDrawMode == Canvas.DrawMode.Triangle)
                {
                    Point[] t = new Point[3];
                    t[0] = _fitstLocation;
                    t[1] = _lastlocation;
                    t[2] = new Point(_fitstLocation.X, _lastlocation.Y);
                    t[0] = new Point((t[1].X + t[2].X) / 2, _fitstLocation.Y);
                    e.Graphics.DrawPolygon(new Pen(new SolidBrush(canvas1.CurrentColour), canvas1.BrushWidth), t);
                }
                else if (canvas1.SelectedDrawMode == Canvas.DrawMode.Diamond)
                {
                    //g.DrawRectangle(a, getRectangle());
                    Point[] d = new Point[4];
                    d[0] = new Point((_fitstLocation.X + _lastlocation.X) / 2, _fitstLocation.Y);
                    d[3] = new Point((_fitstLocation.X + _lastlocation.X) / 2, _lastlocation.Y);
                    d[1] = new Point(_fitstLocation.X, (_fitstLocation.Y + _lastlocation.Y) / 2);
                    d[2] = new Point(_lastlocation.X, (_fitstLocation.Y + _lastlocation.Y) / 2);
                    e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                    var a = new Pen(new SolidBrush(canvas1.CurrentColour), canvas1.BrushWidth)
                    {
                        StartCap = LineCap.Round,
                        EndCap = LineCap.Round
                    };
                    // g.DrawPolygon(a, d);
                    e.Graphics.DrawLine(a, d[0], d[1]);
                    e.Graphics.DrawLine(a, d[1], d[3]);
                    e.Graphics.DrawLine(a, d[3], d[2]);
                    e.Graphics.DrawLine(a, d[2], d[0]);
                }

            }


        }

        private bool _onCanvas = true;
        private void canvas1_MouseHover(object sender, EventArgs e)
        {
            _onCanvas = true;
            canvas1.Invalidate();
            

        }

        private void canvas1_MouseLeave(object sender, EventArgs e)
        {
            //Cursor.Show();
            _onCanvas = false;
        }

        private void canvas1_SizeModeChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                sizes.Items.Clear();
                sizes.Items.AddRange(_penSizes);
            }
            else
            {
                sizes.Items.Clear();
                sizes.Items.AddRange(_otherSizes);
            }
        }
        


        private void sizes_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (radioButton3.Checked)
                {
                    canvas1.PenSize = int.Parse(sizes.Text);
                }
                else
                {
                    canvas1.BrushWidth = int.Parse(sizes.Text);
                    canvas1.LineSize = int.Parse(sizes.Text);
                }
            }
            catch{ sizes.Text = @"10";}
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            canvas1.Fill = checkBox1.Checked;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                //System.Drawing.Drawing2D.LineCap
                case "AnchorMask":
                    canvas1.SetLineAk(LineCap.AnchorMask,false);
                    break;
                case "ArrowAnchor":
                    canvas1.SetLineAk(LineCap.ArrowAnchor, false);
                    break;
                case "DiamondAnchor":
                    canvas1.SetLineAk(LineCap.DiamondAnchor, false);
                    break;
                case "Flat":
                    canvas1.SetLineAk(LineCap.Flat, false);
                    break;
                case "NoAnchor":
                    canvas1.SetLineAk(LineCap.NoAnchor, false);
                    break;
                case "Round":
                    canvas1.SetLineAk(LineCap.Round, false);
                    break;
                case "RoundAnchor":
                    canvas1.SetLineAk(LineCap.RoundAnchor, false);
                    break;
                case "Square":
                    canvas1.SetLineAk(LineCap.Square, false);
                    break;
                case "SquareAnchor":
                    canvas1.SetLineAk(LineCap.SquareAnchor, false);
                    break;
                case "Triangle":
                    canvas1.SetLineAk(LineCap.Triangle, false);
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBox1.Text)
            {
                case "AnchorMask":
                    canvas1.SetLineAk(LineCap.AnchorMask, true);
                    break;
                case "ArrowAnchor":
                    canvas1.SetLineAk(LineCap.ArrowAnchor, true);
                    break;
                case "DiamondAnchor":
                    canvas1.SetLineAk(LineCap.DiamondAnchor, true);
                    break;
                case "Flat":
                    canvas1.SetLineAk(LineCap.Flat, true);
                    break;
                case "NoAnchor":
                    canvas1.SetLineAk(LineCap.NoAnchor, true);
                    break;
                case "Round":
                    canvas1.SetLineAk(LineCap.Round, true);
                    break;
                case "RoundAnchor":
                    canvas1.SetLineAk(LineCap.RoundAnchor, true);
                    break;
                case "Square":
                    canvas1.SetLineAk(LineCap.Square, false);
                    break;
                case "SquareAnchor":
                    canvas1.SetLineAk(LineCap.SquareAnchor, true);
                    break;
                case "Triangle":
                    canvas1.SetLineAk(LineCap.Triangle, true);
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                sizes.Text = (int.Parse(sizes.Text) - 1).ToString();
            }
            catch
            {
                // ignored
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                sizes.Text = (int.Parse(sizes.Text) + 1).ToString();
            }
            catch
            {
                // ignored
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Text != "")
            {
                canvas1.Image.Save(Text);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var s = new SaveFileDialog()
            {
                Filter = "Bitmap Files (*.bmp)|*.bmp|JPEG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg" +
             "|PCX Files (*.pcx)|*.pcx|PNG Files (*.png)|*.png" +
             "|GIF Files (*.gif)|*.gif" +
             "|Wireless Bitmap Files (*.wbm, *.wbmp)|*.wbm;*.wbmp" +
             "|Adobe Photoshop Files (*.psd)|*.psd" +
             "|TIFF Files (*.tif, *.tiff)|*.tif;*.tiff" +
             "|All Image Files|*.bmp;*.jpg;*.jpeg;*.pcx;*.png;*.gif;*.wbm;*.wbmp;*.psd;*.tif;*.tiff"
            })
            {
                if(s.ShowDialog() == DialogResult.OK)
                {
                    canvas1.Image.Save(s.FileName);
                    Text = s.FileName;
                }
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                canvas1.currentFont = fontDialog1.Font;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            canvas1.textToDraw = textBox1.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"X: {canvas1._mousePosition.X},Y: {canvas1._mousePosition.Y}";
            if(canvas1.SelectedDrawMode == Canvas.DrawMode.ClickLine || canvas1.SelectedDrawMode == Canvas.DrawMode.Line)
            {
                panel4.Hide();
                panel5.Show();
            }
            else if (canvas1.SelectedDrawMode == Canvas.DrawMode.Text)
            {
                panel4.Show();
                panel5.Hide();
            }
            else
            {
                panel4.Hide();
                panel5.Hide();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void canvas1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in Xs)
            {
                e.Graphics.DrawLine(Pens.Red, new Point(item, 0), new Point(item, pictureBox1.Height));
            }
            e.Graphics.DrawLine(Pens.Red, new Point(canvas1._mousePosition.X, 0), new Point(canvas1._mousePosition.X, pictureBox1.Height));
        }
        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in Xs)
            {
                e.Graphics.DrawLine(Pens.Red, new Point(item, 0), new Point(item, pictureBox1.Height));
            }
            e.Graphics.DrawLine(Pens.Red, new Point(canvas1._mousePosition.X, 0), new Point(canvas1._mousePosition.X, pictureBox1.Height));

        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in Ys)
            {
                e.Graphics.DrawLine(Pens.Red, new Point(0, item), new Point(pictureBox1.Height, item));

            }
            e.Graphics.DrawLine(Pens.Red, new Point(0, canvas1._mousePosition.Y), new Point(pictureBox1.Width, canvas1._mousePosition.Y));

        }
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            foreach (var item in Ys)
            {
                e.Graphics.DrawLine(Pens.Red, new Point(0,item), new Point(pictureBox1.Height,item));

            }
            e.Graphics.DrawLine(Pens.Red, new Point(0,canvas1._mousePosition.Y), new Point(pictureBox1.Width,canvas1._mousePosition.Y));

        }

        private void bookmarkXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xs.Add(canvas1._mousePosition.X);
        }
        
        private void bookmarkYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ys.Add(canvas1._mousePosition.Y);
        }

        private void clearXBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xs.Clear(); Ys.Clear();
        }

        private void clearYBookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ys.Clear();
        }

        private void bookmarkPointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ys.Add(canvas1._mousePosition.Y);
            Xs.Add(canvas1._mousePosition.X);
        }

        private void clearAllPointsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xs.Clear(); Ys.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}