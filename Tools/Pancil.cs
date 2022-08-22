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
    public class Pancil : IPaintable
    {
        public int _index = 0;
        public Point[] _points = new Point[2];

        public Bitmap Icon => Resources.Pencil;

        public string ToolTitle => nameof(Pancil);

        public void AddPoint(int x, int y)
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

        public Point[] GetPoints()
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
            this.AddPoint(x, y);
            if (this.GetPoints().Length >= 2)
            {
                graphics.DrawLines(pen, this.GetPoints());
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
