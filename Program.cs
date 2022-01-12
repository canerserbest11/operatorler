using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, c = 4;
            bool sonuc = a > c;
            Console.WriteLine(sonuc);
            bool sonuc1 = a >= c;
            Console.WriteLine(sonuc1);
            bool sonuc2 = a < c;
            Console.WriteLine(sonuc2);
            Console.Read();
        }
    }
}