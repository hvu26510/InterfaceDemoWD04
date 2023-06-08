using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nhap vao 1 so nguyen");
            //int x =0;
            //try
            //{
            //    x = int.Parse(Console.ReadLine());
            //}catch(Exception ex)
            //{
            //    Console.WriteLine($"So nguyen khong hop len");
            //}
            //finally
            //{
            //    if(x > 10)
            //    {
            //        Console.WriteLine("x = " + x);
            //    }
            //}

            //double diem = 0;

            //try
            //{
            //    diem = NhapDiem();
            //}catch (CheckScroreException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}


            string name = "";
            try
            {
                name = NhapHoTen();
            }catch(CheckNameException ex)
            {
                Console.WriteLine(ex.Message);
            }


            

            Console.ReadLine();
        }

        static double NhapDiem()
        {
            double diem = -1;
            Console.WriteLine("Nhap vao Diem");
            diem = double.Parse(Console.ReadLine());

            if (diem < 0 || diem > 10)
            {
                throw new CheckScroreException("Diem khong hop le");
            }

            return diem;

        }

        static string NhapHoTen()
        {
            string str = "";

            Console.WriteLine("Nhap ho ten:");
            str = Console.ReadLine();

            if(str.Trim() == "")
            {
                throw new CheckNameException("Ho va ten trong");
            }
            return str;
        }
    }
}
