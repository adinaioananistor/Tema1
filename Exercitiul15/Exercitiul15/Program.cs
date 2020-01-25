using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul15
{
    class Program
    {
        static void Main(string[] args)
        {
            string sir1, sir2;
            Console.Write("Introduceti primul sir:");
            sir1 = Console.ReadLine();
            Console.WriteLine("Primul sir este:'{0}'", sir1);
            Console.Write("Introduceti al 2 lea sir:");
            sir2 = Console.ReadLine();
            Console.WriteLine("Al 2 lea sir este:'{0}'", sir2);
            int longestCommonSubsequence = LCS(sir1, sir2, 0, 0);
            Console.WriteLine(longestCommonSubsequence);
            Console.Read();

        }
        public static int LCS(String sir1, String sir2, int index1, int index2)
        {
            int max = 0;
            if (index1 == sir1.Length)
            {
                //You have reached beyond A and thus no subsequence
                return 0;
            }
            if (index2 == sir2.Length)
            {   //you may reach end of 2nd string. LCS from that end is 0
                return 0;
            }

            for (int i = index1; i < sir1.Length; i++)
            {
                int exist = sir1.IndexOf(sir1[i], index2);
                if (exist != -1)
                {
                    //   found = true;

                    int temp = 1 + LCS(sir1, sir2, i + 1, exist + 1);
                    if (max < temp)
                    {
                        max = temp;
                    }


                }


            }
            return max;

        }
    }
}

