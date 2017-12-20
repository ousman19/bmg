using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;
            Console.WriteLine("Adınızı Giriniz:");
            x = Console.ReadLine();
            foreach (char y in x)
            Console.Write((char)(y + 10));
            Console.ReadKey();
        }
    }
}
