using System;
namespace Ses4SimpleClassExample
{
    public class Motorcycle
    {
        public int intensity;
        public string name;
        public Motorcycle()
        {

        }
        public Motorcycle(int intensity, string name)
        {
            this.intensity = intensity;
            this.name = name;
        }
        public void PopAWheely(){
            Console.WriteLine("Yeeeeeehaaaaaeeeee!");
        }
    }
}
