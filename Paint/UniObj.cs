using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    public class UniObj
    {
        public Point start { get; set; }
        public Point end { get; set; }
        public string Title { get; set; }
        public Action<Graphics, Pen, int, int> Draw { get; set; }
        public Action<int, int> AddPoint { get; set; }
        public Action DisposeItem { get; set; }

        public UniObj DeepCopy()
        {
            UniObj uniObj = (UniObj) this.MemberwiseClone();
            return uniObj;
        }
    }
}
