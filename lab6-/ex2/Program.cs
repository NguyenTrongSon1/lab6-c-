using System;

namespace ex2
{
    interface Ianimal
    {
        void Habitat();
    }
    class dog : Ianimal
    {
        public void Habitat()
        {
            Console.WriteLine("Can be housed with human beings");
        }
        static void Main(string[] args)
        {
            dog objdog = new dog();
            Console.WriteLine(objdog.GetType().Name);
            objdog.Habitat();
        }
    }
}
