using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    //Members of a class are accessed via inheritance 
    internal class AccessSpecifier2 : Class1
    {

        static void Main()
        {
            AccessSpecifier2 t = new AccessSpecifier2();
            t.test1();  t.test3(); t.test4(); t.test5();
            // private members of a class can't be accessed outside the class

        }
    }
}
