using System;
namespace Ses4SimpleClassExample
{
    public class Motorcycle
    {
        public int intensity;
        public string name;
        public Motorcycle(){}
        public Motorcycle(int intensity) : this(intensity, "")
        {
        }
        public Motorcycle(string name) : this(0, name)
        {
        }
        public Motorcycle(int intensity, string name)
        {
            if (intensity > 10)
            {
                intensity = 10;
            }
            this.intensity = intensity;
            this.name = name;
        }

        public void PopAWheely()
        {
            Console.WriteLine("Yeeeeeehaaaaaeeeee!");
        }
    }
}
