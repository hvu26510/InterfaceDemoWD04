using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoWD04
{
    internal class ChuNhat
    {
        public double dai;
        public double rong;

        public ChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }
        public void ShowDienTich()
        {
            Console.WriteLine("Dien tich" + this.dai * this.rong);
        }
    }

    class Vuong : ChuNhat
    {
        public Vuong(double canh)
            :base(canh,canh)
        {
            this.dai=canh;
            this.rong=canh;
        }

        
    }
}
