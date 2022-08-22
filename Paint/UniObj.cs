using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Paint
{
    public class UniObj
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public int Width { get; set; }
        public string Title { get; set; }
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

        [XmlIgnore]
        public Color Color { get; set; }
        [XmlIgnore]
        public Action<Graphics, Pen, int, int> Draw { get; set; }
        [XmlIgnore]
        public Action<int, int> AddPoint { get; set; }
        [XmlIgnore]
        public Action DisposeItem { get; set; }

        public UniObj DeepCopy()
        {
            UniObj uniObj = (UniObj)this.MemberwiseClone();
            return uniObj;
        }


    }
}
