using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CarInv3
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

            public void PrintDetails()
            {
                Console.WriteLine($"Top Speed: {TopSpeed}");
                Console.WriteLine($"Handling: {Handling}");
                Console.WriteLine($"Nitro: {Nitro}");
            }

            public void UpdateAttributes(int newTopSpeed, float newHandling, int newNitro)
            {
                TopSpeed = newTopSpeed;
                Handling = newHandling;
                Nitro = newNitro;
            }
        }

        public class SuperCar : Car
        {
            public override void UpdateSpeed(int newValue)
            {
                base.UpdateSpeed(newValue);
            }
        }

        public class Sedan : Car
        {
            public override void UpdateSpeed(int newValue)
            {
                base.UpdateSpeed(newValue);
            }
        }

        public class SUV : Car
        {
            public override void UpdateSpeed(int newValue)
            {
                base.UpdateSpeed(newValue);
            }
        }

        public class Minivan : Car
        {
            public override void UpdateSpeed(int newValue)
            {
                base.UpdateSpeed(newValue);
            }
        }

        static void Main(string[] args)
        {
            Sedan sedan = new Sedan();
            sedan.TopSpeed = 200;
            sedan.Handling = 4.2f;
            sedan.Nitro = 1;
            sedan.Prev = 150;

            SUV suv = new SUV();
            suv.TopSpeed = 180;
            suv.Handling = 3.5f;
            suv.Nitro = 2;
            suv.Prev = 160;

            Minivan minivan = new Minivan();
            minivan.TopSpeed = 180;
            minivan.Handling = 4.8f;
            minivan.Nitro = 0;
            minivan.Prev = 155;

            SuperCar supercar = new SuperCar();
            supercar.TopSpeed = 1000;
            supercar.Handling = 4.0f;
            supercar.Nitro = 3;
            supercar.Prev = 500;

            Console.WriteLine("Initial Details:");
            Console.WriteLine("Sedan:");
            sedan.PrintDetails();
            Console.WriteLine("\nSUV:");
            suv.PrintDetails();
            Console.WriteLine("\nMinivan:");
            minivan.PrintDetails();
            Console.WriteLine("\nSuper Car:");
            supercar.PrintDetails();

            // Update attributes
            Console.WriteLine("\n\nUpdating Attributes:");
            sedan.UpdateAttributes(220, 4.5f, 2);
            suv.UpdateAttributes(200, 3.8f, 1);
            minivan.UpdateAttributes(190, 5.2f, 3);
            supercar.UpdateAttributes(1100, 4.3f, 0);

            // Print updated details
            Console.WriteLine("\nUpdated Details:");
            Console.WriteLine("Sedan:");
            sedan.PrintDetails();
            Console.WriteLine("\nSUV:");
            suv.PrintDetails();
            Console.WriteLine("\nMinivan:");
            minivan.PrintDetails();
            Console.WriteLine("\nSuper Car:");
            supercar.PrintDetails();
        }
    }
}

