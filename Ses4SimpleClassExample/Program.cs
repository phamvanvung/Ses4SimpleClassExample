using System;

namespace Ses4SimpleClassExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car c = new Car();
            c.petName = "John";
            c.currSpeed = 0;
            for (int i = 0; i <= 10; i++)
            {
                c.PrintState();
                c.SpeedUp(10);
            }
            Console.ReadLine();
        }
    }
}
