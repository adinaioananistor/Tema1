using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiu4
{
   
    public class PalindromExemplu
    {
        static void Main(string[] args)
        {
            string _inputstr, _reversestr = string.Empty;
            Console.Write("Introduceti sirul: ");
            _inputstr = Console.ReadLine();
            if (_inputstr != null)
            {
                for (int i = _inputstr.Length - 1; i >= 0; i--)
                {
                    _reversestr += _inputstr[i].ToString();
                }
                if (_reversestr == _inputstr)
                {
                    Console.WriteLine("Sirul este palindrom!");
                    Console.WriteLine("Input = {0}", _inputstr);
                    Console.WriteLine("Output = {0}", _reversestr);
                }
                else
                {
                    Console.WriteLine("Sirul NU este palindrom!");
                    Console.WriteLine("Input = {0}", _inputstr);
                    Console.WriteLine("Output = {0}", _reversestr);
                }
            }
            Console.ReadLine();
        }

    }
}
