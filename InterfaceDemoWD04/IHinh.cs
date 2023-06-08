using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoWD04
{
    internal interface IHinh
    {
        double dienTich { get; set; }

        void TinhDienTich();
    }

    interface IColor 
    {
        string color { get; set; }
        void showColor();
    }
 

    class HinhTron : IHinh, IColor
    {
        public double banKinh { get; set; }

        public double dienTich { get; set; }

        public string color { get; set; }

        public void TinhDienTich()
        {
            this.dienTich = Math.PI * banKinh * banKinh;
        }

        public void showColor()
        {
            Console.WriteLine("Mau sac: " + this.color);
        }
    }
    class HinhChuNhat : IHinh
    {
        public double cao { get; set; }
        public double rong { get; set; }
        public double dienTich { get; set; }

        public void TinhDienTich()
        {
            this.dienTich = this.rong * this.cao;
        }
    }



}
