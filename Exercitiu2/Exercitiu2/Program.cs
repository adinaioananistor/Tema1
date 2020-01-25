using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu2
{
    class Program
    {   
        static void Main(string[] args)
        {
           
            int[] sirul = new int[5];
            int i;
            Console.Write("Sirul este:\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("element de pe pozitia {0} este : ", i);
                sirul[i] = int.Parse(Console.ReadLine());
            }
            
            Console.Write("Elementele sirului sunt:");
            for (i = 0; i < 5; i++)
            {
                Console.Write(" {0}", sirul[i]);
            }
            
            Console.WriteLine();
            Console.Write("Noul sir este:\n");
            Console.Write(" "+sirul.First());
            Console.Write(" " +sirul.Last());
            Console.Read();

        }
    }
    }

