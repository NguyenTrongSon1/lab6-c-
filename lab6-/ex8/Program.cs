using System;

namespace ex8
{
    class Program
    {
        interface ISet
        {
            void AcceptDetails(int valOne, string valTwo);
        }
        interface IGet
        {
            void display();
        }
        class Employee : ISet
        {
            int _empID;
            string _empName;
            public void AcceptDetails(int valOne,string valTwo)
            {
                _empID = valOne;
                _empName = valTwo;
            }
            static void Main(string[] args)
            {
                Employee objEmployee = new Employee();
                objEmployee.AcceptDetails(10, "Jack");
                IGet objGet = objEmployee as IGet;
                if(objGet != null)
                {
                    objGet.display();
                }
                else
                {
                    Console.WriteLine("Invalid casting occurred");
                }
            }
        }
    }
}
