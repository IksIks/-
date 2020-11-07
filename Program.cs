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
            string[] sovet = new string[5];
            sovet [0] = "1";
            sovet [1] = "a";
            sovet [2] = "b";
            sovet [3] = "c";
            sovet [4] = "d";

            Random x = new Random();
            int a = int.Parse(sovet[0]);
            Console.WriteLine(a);
        }
    }
}
