using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Советы
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sovet = new string[7];
            sovet [0] = "1";
            sovet [1] = "2";
            sovet [2] = "3";
            sovet [3] = "4";
            sovet [4] = "5";
            sovet [5] = "6";
            sovet [6] = "7";

            Random x = new Random();
            for (int i = 0; i < sovet.Length; i++)
            {
               int a = int.Parse(sovet[i]);
                Console.WriteLine(a);
            }
            Console.ReadKey();

        }
    }
}
