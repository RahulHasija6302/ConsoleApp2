namespace ConsoleApp2
{
    internal class CopyConstructor
    {

        //Copy Constructor
        int x;
        public CopyConstructor(int i)
        {
            x = i;
        }
        //Here the whole constructor is being passed --> Copy Constructor
        public CopyConstructor(CopyConstructor obj)
        {
           x = obj.x;
        }
        void display()
        {
            Console.WriteLine("Value of x is: " + x);
        }
        static void Main(string[] args)
        {

            
            CopyConstructor p1 = new CopyConstructor(10);
            p1.display();
            
            CopyConstructor p2 = new CopyConstructor(p1);
            p2.display();
        }
    }
}
