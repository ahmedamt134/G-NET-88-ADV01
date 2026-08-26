using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_88_ADV0
{
    internal class FindMax
    {
        
        public static void findmax<T>(T NUM1 , T NUM2) where T : IComparable<T>
        {
            if (NUM1.CompareTo(NUM2) > 0)
            {
                Console.WriteLine(NUM1); 
            }
            else
            {
                Console.WriteLine(NUM2); 
            }
        }
    }
}
