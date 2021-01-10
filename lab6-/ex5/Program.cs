using System;

namespace ex5
{
    class Program
    {
        interface IAnimal
        {
            void Drink();
        }
        interface ICarnvorous
        {
            void Eat();
        }
        interface IReptile : IAnimal, ICarnvorous
        {
            void Habitat();
        }
        class Crocodile : IReptile
        {
            public void Drink()
            {
                Console.WriteLine("Drinks fresh water");
            }
            public void Habitat()
            {
                Console.WriteLine("Can stay inwater and land");
            }
            public void Eat()
            {
                Console.WriteLine("Eat Fresh");
            }
            static void Main(string[] args)
            {
                Crocodile objCro = new Crocodile();
                Console.WriteLine(objCro.GetType().Name);
                objCro.Habitat();
                objCro.Eat();
                objCro.Drink();
            }
        }
    }
}
