using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_88_ADV0
{
    internal class Container <T>
    {
        private T x;



        public void Add(T _x)
        {
            x = _x;
        }

        public T Get()
        {
            return x;
        }
         
    }
}
