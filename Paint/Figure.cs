using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Paint
{
    public class Figure
    {
        public string ToolTitle { get; set; }

        [XmlIgnore]
        public List<Point> Points { get; set; }

        public int LineWidth { get; set; }

        [XmlIgnore]
        public Color Color { get; set; }

        public int BackColorAsArgb
        {
            get
            {
                return Color.ToArgb();
            }
            set
            {
                Color = Color.FromArgb(value);
            }
        }

        public int[] Arr
        {
            get
            {
                int[] array = new int[Points.Count * 2];
                for (int i = 0; i < Points.Count; i++)
                {
                    array[i * 2] = Points[i].X;
                    array[i * 2 + 1] = Points[i].Y;

                }
                return array;
            }
            set
            {
                List<Point> points = new List<Point>();
                Point point = new Point();

                for (int i = 0; i < value.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        point = new Point();
                        point.X = value[i];
                    }
                    else
                    {
                        point.Y = value[i];
                        points.Add(point);
                    }
                }

                Points = points;
            }
        }

        public Figure()
        {
            Points = new List<Point>();
        }

        public Figure DeepCopy()
        {
            Figure Obj = (Figure)this.MemberwiseClone();
            return Obj;
        }
    }
}
