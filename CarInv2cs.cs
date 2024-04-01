using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CarInv2cs
    {
        public class Car
        {
            public int TopSpeed;
            public float Handling;
            public int Nitro;
            public int Prev;
            public int Amount = 50000;

            public virtual void UpdateSpeed(int newValue)
            {
                if (newValue < Prev)
                {
                    Console.WriteLine($"Adding {Amount * 10} coins.");
                }
                else if (newValue > TopSpeed)
                {
                    Console.WriteLine($"Subtracting {Amount * 15} coins.");
                }
            }
        }

        public class SuperCar : Car
        {
            public override void UpdateSpeed(int newValue)
            {
                if (newValue < Prev)
                {
                    Console.WriteLine($"Subtracting {Amount * 5} coins.");
                }
                else if (newValue > TopSpeed)
                {
                    Console.WriteLine($"Subtracting {Amount * 10} coins.");
                }
            }
        }

        public class Sedan : Car
        {
            public override void UpdateSpeed(int newValue)
            {
                if (newValue < Prev)
                {
                    Console.WriteLine($"Adding {Amount * 10} coins.");
                }
                else if (newValue > TopSpeed)
                {
                    Console.WriteLine($"Subtracting {Amount * 15} coins.");
                }
            }
        }

        public class SUV : Car
        {
            public override void UpdateSpeed(int newValue)
            {
                if (newValue < Prev)
                {
                    Console.WriteLine($"Adding {Amount * 5} coins.");
                }
                else if (newValue > TopSpeed)
                {
                    Console.WriteLine($"Subtracting {Amount * 10} coins.");
                }
            }
        }

        public class Minivan : Car
        {
            public override void UpdateSpeed(int newValue)
            {
                if (newValue < Prev)
                {
                    Console.WriteLine($"Adding {Amount * 10} coins.");
                }
                else if (newValue > TopSpeed)
                {
                    Console.WriteLine($"Subtracting {Amount * 15} coins.");
                }
            }
        }

        static void Main(string[] args)
        {
          
            CarInv2cs ct =  new CarInv2cs();

 
        }
    }
}
