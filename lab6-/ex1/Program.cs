using System;

namespace ex1
{
    class Program
    {
        abstract class Animal
        {
            public void Eat()
            {
                Console.WriteLine("Every animal eats food in order to suvrvive");
            }
            public abstract void AnimalSound();
        }
        class Lion : Animal
        {
            public override void AnimalSound()
            {
                Console.WriteLine("Lion roars");
                
            }
            static void Main(string[] args)
            {
                Lion objlion = new Lion();
                objlion.AnimalSound();
                objlion.Eat();
            }
        }
    }
}
