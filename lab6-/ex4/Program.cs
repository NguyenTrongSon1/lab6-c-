using System;

namespace ex4
{
    class Program
    {
       interface IterrestriaAnimal
        {
            string Eat();
        }
        interface ImarinaAnimal
        {
            string Eat();
        }
        class Crocodile : IterrestriaAnimal, ImarinaAnimal
        {
            string IterrestriaAnimal.Eat()
            {
                string terCro = "Crocodile eats other animals";
                return terCro;
            }
            string ImarinaAnimal.Eat()
            {
                string marCro = "Crocodile eat fish and marine animals";
                return marCro;
            }
            public string EatTerrstrial()
            {
                IterrestriaAnimal objTerAnimal;
                objTerAnimal = this;
                return objTerAnimal.Eat();
            }
            public string EatMarina()
            {
                ImarinaAnimal objMarAnimal;
                objMarAnimal = this;
                return objMarAnimal.Eat();
            }
            static void Main(string[] args)
            {
                Crocodile objCrocodile = new Crocodile();
                string terCro = objCrocodile.EatTerrstrial();
                Console.WriteLine(terCro);
                string marCro = objCrocodile.EatMarina();
                Console.WriteLine(marCro);
            }
        }
    }
}
