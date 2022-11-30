using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test;

namespace CSConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var xsArray = XLib.Functions.Test_XS();
            var csArray = CSClass.Test_CS();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
