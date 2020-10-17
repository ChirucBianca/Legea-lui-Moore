using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legea_lui_Moore
{
    class Program
    {
        static void Main(string[] args)
        {
            double m=0;
            int n, t=0;
            n = int.Parse(Console.ReadLine());
            while(m<n)
            {
                m = m + 0.11;
                t++;
            }
            Console.WriteLine(t-1);
            Console.ReadKey();
        }
    }
}
