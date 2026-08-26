using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_88_ADV0
{
    internal class Pair<TKey, TValue>
    {
        private TKey x;
        private TValue y;



        public void Add(TKey _x, TValue _y)
        {
            x = _x;
            y = _y;
        }


        public override string ToString()
        {
            return $"{x},{y}";
        }
    }
}
