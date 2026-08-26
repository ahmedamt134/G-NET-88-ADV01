using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_88_ADV0
{
    internal interface IRepository<T>
    {
        void Add(T _x);
        T Get();
    }
}
