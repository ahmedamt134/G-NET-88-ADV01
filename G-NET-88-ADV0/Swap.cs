using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_88_ADV0
{
    internal class Swap
    {
        public static void swap<T>(ref T x ,ref T y)
        {
      
            T item = x;
            x= y;
            y= item;
        }
    }
}
