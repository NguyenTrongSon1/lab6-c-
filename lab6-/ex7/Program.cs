using System;

namespace ex7
{

    interface ICalculate
    {
        double Area();
    }
    class Rectangle : ICalculate
    {
        float _length;
        float _breadth;
        public Rectangle(float valOne, float valTwo)
        {
            _length = valOne;
            _breadth = valTwo;
        }
        public double Areaa()
        {
            return _breadth + _breadth;
        }
        static void Main(string[] args)
        {
            Rectangle objRectangle = new Rectangle(10.2F, 20.3F);
            if (objRectangle is ICalculate)
            {
                Console.WriteLine("Area of rectangle: {0:F2}", objRectangle.Areaa());
            }
            else
            {
                Console.WriteLine("interface method not implemented");
            }
        }

    }
}
