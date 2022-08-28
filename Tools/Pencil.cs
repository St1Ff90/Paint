using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModderPack;
using Tools.Properties;

namespace Tools
{
    public class Pencil : IPaintable
    {
        public int _index = 0;
        public Point[] _points = new Point[2];
        ////public Point _start;
        ////public Point _end;

        public Bitmap Icon => Resources.Pencil;

        public string ToolTitle => nameof(Pencil);

        public int needPointsToDraw => int.MaxValue;

        public void Start(int x, int y)
        {
            ////_start = new Point(x, y);


            if (_points.Length <= _index)
            {
                Point[] temp = _points;
                _points = new Point[temp.Length * 2];
                for (int i = 0; i < temp.Length; i++)
                {
                    _points[i] = temp[i];
                }

            }
            _points[_index] = new Point(x, y);
            _index++;
        }

        public Point[] GetPointsArr()
        {
            Point[] points = new Point[_index];
            for (int i = 0; i < _index; i++)
            {
                points[i] = _points[i];
            }
            return points;
        }

        public void Draw(Graphics graphics, Pen pen, int x, int y)
        {
            ////_end = new Point(x, y);
            ////graphics.DrawLine(pen, _start, _end);

            this.Start(x, y);
            if (this.GetPointsArr().Length >= 2)
            {
                graphics.DrawLines(pen, this.GetPointsArr());
            }
        }

        public void ClearObj()
        {
            _index = 0;
            _points = new Point[2];
        }

        public void Fill(Graphics graphics, Brush brush, int x, int y, int borderWidth)
        {
            graphics.FillRectangle(brush, 0, 0, 0, 0);
        }

        public double Distance(Point point, Point start, Point end)
        {
            int maxX = Math.Max(start.X, end.X);
            int minX = Math.Min(start.X, end.X);
            int maxY = Math.Max(start.Y, end.Y);
            int minY = Math.Min(start.Y, end.Y);

            int border = 10;

            if (point.X > maxX + border || point.X < minX - border || point.Y > maxY + border || point.Y < minY - border)
            {
                return double.MaxValue;
            }

            double dx = point.X, dy = point.Y, x1 = start.X, y1 = start.Y, x2 = end.X, y2 = end.Y;
            double double_area = Math.Abs((y2 - y1) * dx - (x2 - x1) * dy + x2 * y1 - y2 * x1);
            double line_segment_length = Math.Sqrt(x2 * x2 - 2 * x2 * x1 + x1 * x1 + y2 * y2 - 2 * y2 * y1 + y1 * y1);
            return double_area / line_segment_length;
        }
    }
}
