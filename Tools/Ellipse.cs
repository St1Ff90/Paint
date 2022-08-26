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

            graphics.DrawEllipse(pen, _start.X, _start.Y, width, height);
        }

        public void Fill(Graphics graphics, Brush brush, Point start, Point end)
        {
            throw new NotImplementedException();
        }

        public double Distance(Point point, Point start, Point end)
        {
            throw new NotImplementedException();
        }
    }
}
