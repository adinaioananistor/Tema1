using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul9
{
    class Program
    {
        static void Main(string[] args)
        {
            string sir;
            Console.Write("Introduceti sirul:");
            sir = Console.ReadLine();
            Console.WriteLine("Sirul introdus este:'{0}'", sir);
            Console.WriteLine(string.Join(" ", sir.Split(' ').Reverse()));
            Console.Read();

        }
    }
}
