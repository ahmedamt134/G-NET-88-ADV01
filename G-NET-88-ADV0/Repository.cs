using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_88_ADV0
{
    internal class Repository : IRepository<int>
    {
        public int x;
        public void Add(int _x)
        {
            x = _x;
        }

        public int Get()
        {
            return x;
        }
    }
}
