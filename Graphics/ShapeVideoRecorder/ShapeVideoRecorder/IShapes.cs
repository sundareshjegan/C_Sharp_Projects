using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeVideoRecorder
{
    internal interface IShapes
    {
        int StartX { get; set; }

        int StartY { get; set; }

        int EndX { get; set; }

        int EndY { get; set; }
    }
}
