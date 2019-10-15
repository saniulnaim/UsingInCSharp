using System;

namespace UsingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //without using statement
            Car carObjWithoutUsing = new Car();
            Console.WriteLine(carObjWithoutUsing.Name);

            //with using statement
            using (Car carObjWithUsing = new Car())
            {

            }
        }
    }
}
