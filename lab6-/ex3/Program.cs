using System;

namespace ex3
{
    class Program
    {
        interface IterrestrialAnimal
        {
            void Eat();
        }
        interface ImarineAnimal
        {
            void Swim();
        }
        class Crocodile : IterrestrialAnimal, ImarineAnimal
        {
            public void Eat()
            {
                Console.WriteLine("The crocodile eats flesh");
            }
            public void Swim()
            {
                Console.WriteLine("The crocodile can swimfour times faster than an Olympic swimmer");

            }
            static void Main(string[] args)
            {
                Crocodile objcro = new Crocodile();
                objcro.Eat();
                objcro.Swim();
            }
        }
    }
}
