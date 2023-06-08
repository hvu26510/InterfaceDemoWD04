using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemoWD04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IHinh tron;
            HinhTron tron = new HinhTron()
            {
                banKinh = 10,
                color = "Blue"
            };
            tron.TinhDienTich();


            Console.WriteLine("Dien tich hinh tron: " + tron.dienTich);
            tron.showColor();



            //HinhChuNhat hcn = new HinhChuNhat()
            //{
            //    cao = 10,
            //    rong = 20,
            //};

            //hcn.TinhDienTich();

            //Console.WriteLine("Dien tich hinh chu nhat: " + hcn.dienTich);

            TinhToan t = new TinhToan();

            Console.WriteLine(t.Add(1, 2));

            Console.WriteLine(t.Add(1.5,2));


            Console.ReadLine();


        }
    }
   
}
