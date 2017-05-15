using System;

namespace Ses4SimpleClassExample
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Car c = new Car();

            for (int i = 0; i <= 10; i++)
            {
                c.PrintState();
                c.SpeedUp(10);
            }
            Console.ReadLine();
        }
    }
}
