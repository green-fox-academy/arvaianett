using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Counter
    {
        public int C { get; set; }       

        public Counter()
        {
            C = 0;
        }

        public void Add()
        {
            C += 1;
        }

        public void Get()
        {
            C.ToString() ;
        }

        public void Reset()
        {
            C = 0;
        }
    }
}
