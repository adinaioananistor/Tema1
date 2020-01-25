using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            int number2;
            List<int> listFinal = new List<int>();
            List<int> listFinal1 = new List<int>();
            List<int> list = new List<int>
            {
              1,1,2,3,5,8,13,21,34,55,89
            };
            Console.WriteLine("Lista originala:");

            foreach (int i in list)
            {
                Console.Write(" " + i);
            }
            
            List<int> distinct = list.Distinct().ToList();
            Console.WriteLine();
            Console.WriteLine("Lista dupa eliminarea duplicatelor este:");
            foreach (int res in distinct)
            {
                Console.Write(" {0}", res);
                
            }
            for(int a=0;a<distinct.Count;a++)
            {
                distinct[a].CompareTo(number);
                if(distinct[a]<number)
                {
                    listFinal.Add(distinct[a]);
                    

                }
               

            }
            Console.WriteLine();
            Console.Write("Numerele mai mici decat 5 din sir sunt:");
            foreach (int k in listFinal)
            {

                Console.Write(" {0}", k);
            }
            Console.WriteLine();
            Console.WriteLine("Nr este:");
            number2 = int.Parse(Console.ReadLine());
            for (int a = 0; a < distinct.Count; a++)
            {
                distinct[a].CompareTo(number2);
                if (distinct[a] < number2)
                {
                    listFinal1.Add(distinct[a]);


                }


            }
            Console.WriteLine();
            Console.Write("Numerele mai mici decat numarul introdus din sir sunt:");
            foreach (int k in listFinal1)
            {

                Console.Write(" {0}", k);
            }

            Console.Read();
        }
    }
}
