using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tues_Classwork_26_Feb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(M(i: 15));
            Console.WriteLine(M(15, 3));
            Console.WriteLine(M(i: 15, offset: 3));
            Console.WriteLine(M(scale: 7, i: 3));
            Console.ReadLine();
        }

        static int M(int i) => M(i, 1);
        static int M(int i, int scale) => M(i, scale, 0);
        static int M(int i, int scale = 1, int offset = 0) => offset + i * scale;
    }
}
