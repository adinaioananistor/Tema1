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
            List<int> list = ReadListFromConsole();
            Console.Write("The new list is:\n");
            TakeTheFirstElement(list);
            TakeTheLastElement(list);
            Console.Read();

        }
        public static void TakeTheFirstElement(List<int> list)
        {
            Console.Write(" " + list.First());
        }
        public static void TakeTheLastElement(List<int> list)
        {
            Console.Write(" " + list.Last());
        }

        public static List<int> ReadListFromConsole()
        {
            List<int> list = new List<int>();
            Console.WriteLine("List:");

            string input = Console.ReadLine();

            string numberSoFar = "";
            for (int i = 0; i < input.Length; i++)
            {


                if (Char.IsDigit(input[i]))
                {
                    numberSoFar += input[i];
                }
                else
                {

                    list.Add(int.Parse(numberSoFar));
                    numberSoFar = "";
                }


            }
            list.Add(int.Parse(numberSoFar));
            return list;

        }
    }
}

