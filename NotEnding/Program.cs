using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotEnding
{
    class Program
    {
        static void Main(string[] args)
        {
            int Endless = 0;
            int sum = 0;
            int pro = 1;
            Console.WriteLine("Введите число p");
            int p = Convert.ToInt32(Console.ReadLine());
            while (sum < p)
            {
                Console.Write(Endless + " ");
                sum += Endless;
                Endless++;
            }
            Console.WriteLine();
            Console.WriteLine("Сумма = " + sum);
            while (pro < p)
            {
                Console.Write(Endless + " ");
                pro *= Endless;
                Endless++;
            }
            Console.WriteLine();
            Console.WriteLine("Произведение = " + pro);
            Console.ReadKey();
        }
    }
}
