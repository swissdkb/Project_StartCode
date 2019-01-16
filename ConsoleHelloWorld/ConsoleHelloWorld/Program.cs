using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace ConsoleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = Calculator.Sub(3, 3);
            Console.WriteLine(result);
        }
    }
}
