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
    public class Line : IPaintable
    {
        public Point _end;
        public Point _start;
        public Bitmap Icon => Resources.Line;

        public string ToolTitle => nameof(Line);

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
            graphics.DrawLine(pen, _start, _end);
        }

        public void Fill(Graphics graphics, Brush brush, Point start, Point end)
        {
            throw new NotImplementedException();
        }
    }
}
