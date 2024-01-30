using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeVideoRecorder
{
    public class Circle:IShapes
    {
        public int StartX { get; set; }

        public int StartY { get ; set ; }

        public int EndX { get ; set ; }

        public int EndY { get ; set; }

        public Rectangle rect;

        public string ID;

        public Rectangle GetCircle()
        {
            rect = new Rectangle(StartX, StartY, EndX - StartX, EndY - StartY);
            return rect;
        }
    }
}
