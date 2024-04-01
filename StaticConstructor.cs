using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("The constructor is being executed");
        }
        public static void Main()
        {
            //The constructor is being executed without creating the instance --> Static Constructor
        }
    }
    
}
