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
            int ne = 0;
            int sum = 0;
            Console.WriteLine("Введите число p");
            int p = Convert.ToInt32(Console.ReadLine());
            while (sum < p)
            {
                Console.Write(ne + " ");
                sum += ne;
                ne++;
            }
            Console.WriteLine();
            Console.WriteLine("Сумма = " + sum);
            Console.ReadKey();
        }
    }
}
