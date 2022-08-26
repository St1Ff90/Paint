﻿using ModderPack;
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
        public Point _start;
        public Point _end;
        public Bitmap Icon => Resources.Line;

        public string ToolTitle => nameof(Line);

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
            graphics.DrawLine(pen, _start, _end);
        }

        public void Fill(Graphics graphics, Brush brush, Point start, Point end)
        {
            throw new NotImplementedException();
        }

        public double Distance(Point point, Point start, Point end)
        {
            if (start.X + start.Y > end.X + end.Y)
            {
                Point temp = start;
                start = end;
                end = temp;
            }

            if (point.X > end.X + 10 || point.Y > end.Y + 10 || point.X < start.X - 10 || point.Y < start.Y - 10)
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
