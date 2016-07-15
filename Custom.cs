using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите размерность");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            if (n == 1)
            {
                Console.WriteLine("0");
                Console.ReadLine();
                return;
            }

            int rez  = 0;
            int rez1 = 0;
            Console.WriteLine(rez1);
            int rez2 = 1;
            Console.WriteLine(rez2);


            for (int i =2; i < n; i++)
            {
                rez = rez1 + rez2;
                rez1 = rez2;
                rez2 = rez;
                Console.WriteLine(rez);
            }
            Console.WriteLine("Result = {0}",rez);
            Console.ReadLine();

        }
    }
}
