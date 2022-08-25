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
        public Point _end;
        public Point _start;
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

        public void Fill(Graphics graphics, Brush brush, Point start, Point end)
        {
            throw new NotImplementedException();
        }
    }
}
