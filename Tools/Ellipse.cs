using ModderPack;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Properties;

namespace Tools
{
    internal class Ellipse : IPaintable
    {
        public Point _end;
        public Point _start;
        public Bitmap Icon => Resources.Ellipse;

        public string ToolTitle => nameof(Ellipse);

        public int needPointsToDraw => 2;

        public void Start(int x, int y)
        {
            _start = new Point(x, y);
        }

        public void ClearObj()
        {
            return;
        }

        public void Draw(Graphics graphics, Pen pen, int x, int y)
        {
            _end = new Point(x, y);

            int width = _end.X - _start.X;
            int height = _end.Y - _start.Y;

            int centerX = (int)(_start.X + _end.X) / 2;
            int centerY = (int)(_start.Y + _end.Y) / 2;

            graphics.DrawEllipse(pen, _start.X, _start.Y, width, height);
            graphics.DrawRectangle(pen, _start.X, _start.Y, width, height);
            graphics.DrawRectangle(pen, centerX, centerY, 1, 1);
            graphics.DrawLine(pen, new Point(_start.X, centerY), new Point(_end.X, centerY));
            graphics.DrawLine(pen, new Point(centerX, _start.Y), new Point(centerX, _end.Y));
        }

        public void Fill(Graphics graphics, Brush brush, int x, int y, int borderWidth)
        {
            int startFillX = _start.X + borderWidth / 2;
            int startFillY = _start.Y + borderWidth / 2;
            int widthFill = _end.X - _start.X - borderWidth;
            int heightFill = _end.Y - _start.Y - borderWidth;

            graphics.FillEllipse(brush, startFillX, startFillY, widthFill, heightFill);
        }

        public double Distance(Point point, Point start, Point end)
        {
            double centerX = (start.X + end.X) / 2;
            double centerY = (start.Y + end.Y) / 2;
            double width = Math.Abs(end.X - start.X) / 2;
            double height = Math.Abs(end.Y - start.Y) / 2;

            double position = (Math.Pow((point.X - centerX), 2) / Math.Pow(width, 2)) + (Math.Pow((point.Y - centerY), 2) / Math.Pow(height, 2));
            // in point in figure => position will be < 1
            return Math.Abs(position - 1) * 75;
        }
    }
}
