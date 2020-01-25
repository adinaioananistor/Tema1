using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Nr este:");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                    Console.Write(i + " ");
            }
            Console.Read();
        }
    }
}
