using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            //محمد مهدی مهمد کاظمی
            //تکلیف شماره4
            //پیشرفته 1 شهید شمسی پور
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine("please enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{a}\t{b}\t");
            for(int i=2;i <=n;i++)
            {
                c = a + b;
                Console.WriteLine($"{c}\t");
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
