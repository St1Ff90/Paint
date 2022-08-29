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
    internal class Rectangle : IPaintable
    {
        private Point _end;
        private Point _start;
        public Bitmap Icon => Resources.Rectangle;

        public string ToolTitle => nameof(Rectangle);

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

            int startX = Math.Min(_start.X, _end.X);
            int startY = Math.Min(_start.Y, _end.Y);
            int width = Math.Abs(_end.X - _start.X);
            int height = Math.Abs(_end.Y - _start.Y);

            graphics.DrawRectangle(pen, startX, startY, width, height);
        }

        public void Fill(Graphics graphics, Brush brush, int x, int y, int borderWidth)
        {
            int startFillX = Math.Min(_start.X, _end.X) + borderWidth / 2;
            int startFillY = Math.Min(_start.Y, _end.Y) + borderWidth / 2;
            int widthFill = Math.Abs(_end.X - _start.X) - borderWidth;
            int heightFill = Math.Abs(_end.Y - _start.Y) - borderWidth;

            graphics.FillRectangle(brush, startFillX, startFillY, widthFill, heightFill);
        }

        public double Distance(Point point, Point start, Point end)
        {
            const int border = 10;
            int maxX = Math.Max(start.X, end.X);
            int minX = Math.Min(start.X, end.X);
            int maxY = Math.Max(start.Y, end.Y);
            int minY = Math.Min(start.Y, end.Y);

            if (point.X > maxX + border || point.X < minX - border || point.Y > maxY + border || point.Y < minY - border)
            {
                return double.MaxValue;
            }

            var d_top = Math.Abs(start.Y - point.Y);
            var d_bottom = Math.Abs(end.Y - point.Y);
            var corner_y = d_top < d_bottom ? start.Y : end.Y;

            var d_left = Math.Abs(start.X - point.X);
            var d_right = Math.Abs(end.X - point.X);
            var corner_x = d_left < d_right ? start.X : end.X;

            var d_cx = corner_x - point.X;
            var d_cy = corner_y - point.Y;
            var d_corner = Math.Sqrt(d_cx * d_cx + d_cy * d_cy);

            return Math.Min(Math.Min(Math.Min(Math.Min(d_top, d_bottom), d_left), d_right), d_corner);
        }
    }
}
