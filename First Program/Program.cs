using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine(Year.IsLeap(year));
            Console.Read();
        }
    }
}
