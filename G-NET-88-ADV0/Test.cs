using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_88_ADV0
{
    internal class Test<T> where T : struct
    {
        public void Print(T value)
        {
            Console.WriteLine(value);
        }
    }
}
