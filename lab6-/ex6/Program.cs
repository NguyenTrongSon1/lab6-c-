using System;

namespace ex6
{
    class Program
    {
       interface IMath
        {
            void Area();
        }
        class Circle : IMath
        {
            public const float PI = 3.14F;
            protected float radius;
            protected double AreaOfCircle;
            public virtual void Area()
            {
                AreaOfCircle = (PI * radius * radius);
            }
        }
        class Sphere : Circle
        {
            double _areaOfShere;
            public override void Area()
            {
                base.Area();
                _areaOfShere = (AreaOfCircle * 4);
            }
            static void Main(string[] args)
            {
                Sphere objSphere = new Sphere();
                objSphere.radius = 7;
                objSphere.Area();
                Console.WriteLine("Area of sphere: {0:F2}", objSphere._areaOfShere);
            }
        }
    }
}
