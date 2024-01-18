﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobModel
{
    public class Job : IJobModel
    {
        public string Name { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int Price { get; set; }
        public string Model { get; set; }
        public string RName { get; set; }
    }
}
