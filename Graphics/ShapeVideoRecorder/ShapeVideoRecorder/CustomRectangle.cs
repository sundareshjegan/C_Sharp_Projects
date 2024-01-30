using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeVideoRecorder
{
    public class CustomRectangle : IShapes
    {
        
        public int StartX { get; set; }

        public int StartY { get ; set ; }

        public int EndX { get; set; }

        public int EndY { get ; set ; }
        
        public Rectangle rectangle;

        public string ID;

        public Rectangle GetRectangle()
        {
            rectangle = new Rectangle(StartX, StartY, Math.Abs(EndX - StartX), Math.Abs(EndY - StartY));
            return rectangle;
        }
    }
}
