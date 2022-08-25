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

        public Bitmap Icon => Resources.Pencil;

        public string ToolTitle => nameof(Pencil);

        public int needPointsToDraw => int.MaxValue;

        public void Start(int x, int y)
        {
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

        public void Fill(Graphics graphics, Brush brush, Point start, Point end)
        {
            throw new NotImplementedException();
        }
    }
}
