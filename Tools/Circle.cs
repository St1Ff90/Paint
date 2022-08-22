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

        public void AddPoint(int x, int y)
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

            if (width < height)
            {
                side = width;
            }
            else
            {
                side = height;
            }

            graphics.DrawEllipse(pen, _start.X, _start.Y, side, side);
        }

        public void Fill(Graphics graphics, Brush brush, Point start, Point end)
        {
            throw new NotImplementedException();
        }
    }
}
