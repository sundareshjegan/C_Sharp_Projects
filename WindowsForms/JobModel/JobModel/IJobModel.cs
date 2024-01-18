using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobModel
{
    public interface IJobModel
    {
        string Name { get; set; }
        int Row { get; set; }
        int Column { get; set; }
        int Price { get; set; }
    }
}
