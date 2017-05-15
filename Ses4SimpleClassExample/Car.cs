using System;
namespace Ses4SimpleClassExample
{
    public class Car
    {
        //Common characteristics (variables)
        public string petName;
        public int currSpeed;
        //Common behaviors (methods)
        public void PrintState(){
            Console.WriteLine("{0} is going {1} MPH.", petName, currSpeed);
        }
        public void SpeedUp(int delta){
            currSpeed += delta;
        }
    }
}
