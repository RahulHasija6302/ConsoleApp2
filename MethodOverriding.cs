using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MethodOverriding
    {

        //This is an example of method overriding
        class Base
        {
            public virtual void first()
            {
                Console.WriteLine("Method from Base Class");
            }
            public void second() {
                Console.WriteLine("Method 2 from Base Class");
                }
        }
        class Derived : Base{
            public override void first() //Method Overriding
            {
                Console.WriteLine("Method from Derived Class");
            }
            public new void second() //Method Hiding/Shadowing
            {
                Console.WriteLine("Method 2 from Derived Class");
            }
        }
        static void Main()
        {
            Base b = new Base();
            b.first();
            b.second();
            b = new Derived();
            b.first();
            b.second();

        }
    }
}
