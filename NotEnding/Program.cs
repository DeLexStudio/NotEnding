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
            Console.WriteLine("Введите число p");
            int p = Convert.ToInt32(Console.ReadLine());
            while (sum < p)
            {
                Console.Write(Endless + " ");
                sum += Endless;
                Endless++;
            }
            Console.WriteLine("Сумма = " + sum);
            Console.ReadKey();
        }
    }
}
