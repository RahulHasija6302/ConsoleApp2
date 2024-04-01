using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    //3 access specifiers we can't use to specify a class : Private, Protected & Internal Protected
    internal class AccessSpecifier3
    {
        static void Main(string[] args)
        {
            //Here members of AccessSpecifier Class can be accessed by instanstiating an object
            Class1 p1 = new Class1();
            p1.test1();
            p1.test5();
            p1.test4();


            //Here private and protected method can't be accessed because protected method can only be accessed by the child classed via inheritance that's why it can be accessed by 
            //AccessSpecifier2 as it was the child of Class1 namespace 
            


        }
    }
}
