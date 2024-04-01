using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class carInv
    {
        public class Car
        {
            public int topspeed;
            public float handling;
            public int nitro;
            public int prev;
            public int amount = 50000;

            private int pr_c;
            public int p_c;
            protected int prt_c;

            public virtual void UpdateSpeed(int newValue)
            {
                if (newValue < prev)
                {
                    Console.WriteLine($"Adding {amount * 10} coins.");
                }
                else if (newValue > topspeed)
                {
                    Console.WriteLine($"Subtracting {amount * 15} coins.");
                }
            }

        }
        public class SuperCar : Car
        {
            public bool TopSpeed()
            {
                if (topspeed > 0 && topspeed <= 1000)
                {
                    return true;
                }
                return false;


            }
            public override void UpdateSpeed(int newValue)
            {
                if (newValue < prev)
                {
                    Console.WriteLine($"Adding {amount * 10} coins.");
                }
                else if (newValue > topspeed)
                {
                    Console.WriteLine($"Subtracting {amount * 15} coins.");
                }
            }

        }
            public class Sedan : Car
            {
            private int pr_s;
            public int p_s;
            protected int prt_s;
                public bool TopSpeed()
                {
                    if (topspeed >= 140 && topspeed <= 200)
                    {
                        return true;
                    }
                    return false;
                }
                public bool Handling()
                {
                    if (handling >= 3 && handling <= 5)
                    {
                        return true;
                    }
                    return false;
                }
                public override void UpdateSpeed(int newValue)
                {
                    if (newValue < prev)
                    {
                        Console.WriteLine($"Subtracting {amount * 5} coins.");
                    }
                    else if (newValue > topspeed)
                    {
                        Console.WriteLine($"Subtracting {amount * 10} coins.");
                    }
                }

            }
            //public override void UpdateSpeed(int newValue)
            //{
            //    if (newValue < prev)
            //    {
            //        Console.WriteLine($"Subtracting {amount * 5} coins.");
            //    }
            //    else if (newValue > topspeed)
            //    {
            //        Console.WriteLine($"Subtracting {amount * 10} coins.");
            //    }
            //}
            public class SUV : Car
            {
                public bool TopSpeed()
                {
                    if (topspeed >= 150 && topspeed <= 180)
                    {
                        return true;
                    }
                    return false;
                }
                public bool Handling()
                {
                    if (handling >= 1.5 && handling <= 3)
                    {
                        return true;
                    }
                    return false;
                }
                public override void UpdateSpeed(int newValue)
                {
                    if (newValue < prev)
                    {
                        Console.WriteLine($"Adding {amount * 10} coins.");
                    }
                    else if (newValue > topspeed)
                    {
                        Console.WriteLine($"Subtracting {amount * 15} coins.");
                    }
                }

            }
            public class Minivan : Car
            {
                public bool TopSpeed()
                {
                    if (topspeed >= 150 && topspeed <= 180)
                    {
                        return true;
                    }
                    return false;
                }
                public bool Handling()
                {
                    if (handling >= 4 && handling <= 6)
                    {
                        return true;
                    }
                    return false;
                }
                public bool Nitro()
                {
                    if(nitro<=0 && nitro >= 3)
                    {
                        return true;
                    }
                    return false;
                }
            }

            static void Main(string[] args)
            {

              Car car = new Car();

             
              Car c2 = new Sedan();
              
            Sedan s1 = new Sedan();
            //Sedan s2 = new Car();
               
            void access()
            {
                int x = car.p_c;
                Console.WriteLine(x);
                
            }
            }
        }
    }

