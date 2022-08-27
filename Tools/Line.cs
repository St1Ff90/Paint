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
        public List<Point> _points;
        public Bitmap Icon => Resources.Line;

        public string ToolTitle => nameof(Line);

        public int needPointsToDraw => 2;

        public void Start(int x, int y)
        {
            _points = new List<Point>();
            _points.Add(new Point(x, y));
        }

        public void ClearObj()
        {
            return;
        }

        public void Draw(Graphics graphics, Pen pen, int x, int y)
        {
            if(_points.Count == 2)
            {
                _points[1] = new Point(x, y);
            }
            else
            {
                _points.Add(new Point(x, y));

            }
            graphics.DrawLine(pen, _points[0], _points[_points.Count - 1]);
        }

        public void Fill(Graphics graphics, Brush brush, int x, int y, int borderWidth)
        {
            graphics.FillRectangle(brush, 0, 0, 0, 0);
        }
    }
}
