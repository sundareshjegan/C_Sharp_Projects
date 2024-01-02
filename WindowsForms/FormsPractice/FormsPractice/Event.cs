using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsPractice
{
    public class Event
    {
        public event EventHandler Event1;
        public event EventHandler<bool> Event2;
        public event EventHandler<int> Event3;

        public delegate int Add(int a, int b);
        public delegate void Add1(int a, int b);
        public event Add Event4;
        public event Add1 Event5;
    }
}
