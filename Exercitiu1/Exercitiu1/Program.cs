using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = ReadListFromConsole();
            
            int number = 5;
            TrySortList(list);

            bool result = IsTheNumberPresent(list, number);
            Console.WriteLine(result);
            Console.ReadLine();

        }
        public static bool IsTheNumberPresent(List<int> list, int number)
        {
            //bool result;
            //result = list.Contains(number);
            //return result;

            //bool result = list.Contains(number);
            //return result;

            return list.Contains(number);
        }
        public static void TrySortList(List<int> list)
        {
            if (!IsListSorted(list))
            {
                list.Sort();
            }

        }
        public static bool IsListSorted(List<int> list)
        {
            //bool result = true;
            //for (int i = 0; i <= list.Count; i++)
            //{
            //    result = list[i] < list[i + 1];
            //    if (result == false)
            //    {
            //        result = false;
            //    }
            //}

            //return result;
            
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < list[i + 1])
                {
                    return false;
                }
            }

            return true;
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
