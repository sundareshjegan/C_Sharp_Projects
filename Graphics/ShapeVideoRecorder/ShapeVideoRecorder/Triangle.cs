using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeVideoRecorder
{
    public class Triangle : IShapes
    {
        public int StartX { get; set; }

        public int StartY { get; set ; }

        public int EndX { get; set; }

        public int EndY { get ; set; }

        public string ID;

        public Point[] trianglePoints = new Point[3];

        public Point[] GetTrianglePoints()
        {
            trianglePoints[0] = new Point((StartX + EndX) / 2, StartY);
            trianglePoints[1] = new Point(EndX,EndY);
            trianglePoints[2] = new Point(StartX, EndY);

            return trianglePoints;
        }
    }
}
