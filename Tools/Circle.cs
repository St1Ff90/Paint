using ModderPack;
using System.Drawing;
using Tools.Properties;

namespace Tools
{
    internal class Circle : IPaintable
    {
        public Point _end;
        public Point _start;
        public Bitmap Icon => Resources.Circle;

        public string ToolTitle => nameof(Circle);

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
            int side = width;

            if (width > height)
            {
                side = height;
            }
            else
            {
                side = width;
            }

            graphics.DrawEllipse(pen, _start.X, _start.Y, side, side);
        }

        public void Fill(Graphics graphics, Brush brush, int x, int y, int borderWidth)
        {
            int startX = _start.X + borderWidth / 2;
            int startY = _start.Y + borderWidth / 2;
            int widthFill = _end.X - _start.X;
            int heightFill = _end.Y - _start.Y;
            int side = widthFill - borderWidth;

            if (widthFill < heightFill)
            {
                side = heightFill - borderWidth;
            }
            else
            {
                side = widthFill - borderWidth;
            }

            graphics.FillEllipse(brush, startX, startY, side, side);
        }

        public double Distance(Point point, Point start, Point end)
        {
            double width = Math.Abs(end.X - start.X);
            double height = Math.Abs(end.Y - start.Y);
            var diametr = width > height ? height : width;
            double centerX = start.X + diametr / 2;
            double centerY = start.Y + diametr / 2;

            return (double)Math.Abs(Math.Sqrt((point.X - centerX) * (point.X - centerX) + (point.Y - centerY) * (point.Y - centerY)) - diametr / 2);


        }
    }
}
