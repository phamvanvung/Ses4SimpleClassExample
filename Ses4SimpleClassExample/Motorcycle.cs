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
        public Motorcycle(int intensity)
        {
            if(intensity > 10){
                intensity = 10;
            }
            this.intensity = intensity;
        }
        public Motorcycle(int intensity, string name)
        {
            if(intensity > 10){
                intensity = 10;
            }
            this.intensity = intensity;
            this.name = name;
        }

        public void PopAWheely(){
            Console.WriteLine("Yeeeeeehaaaaaeeeee!");
        }
    }
}
