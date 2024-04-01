using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class MethodOverloading
    {
        //This is an example of method overloading
        public void first1(int i)
        {
            Console.WriteLine("This is the first method with single integer: " + i);
        }
        public void first1(int a, int b)
        {
            Console.WriteLine("This is the second method with two integers: " + a +" "+ b);
        }
        static void Main()
        {
            MethodOverloading mt = new MethodOverloading();
            mt.first1(1,2);


        }
    }
}
