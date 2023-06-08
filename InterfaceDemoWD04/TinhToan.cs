using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoWD04
{
    internal class TinhToan
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("Tong int:");
            return a + b;
        }
        public double Add(double a, double b)
        {
            Console.WriteLine("Tong double:");

            return a + b;
        }
    }
}
