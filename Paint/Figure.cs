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
