using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Matrix
    {
        int a, b, c, d;
        public Matrix(int a,int b, int c, int d) { 
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(20, 18, 16, 14);
            Matrix m2 = new Matrix(10, 8, 6, 4);
        }
    }
}
