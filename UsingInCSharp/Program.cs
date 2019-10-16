using System;

namespace UsingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //with using statement
            using (Car carObjWithUsing = new Car())
            {
                Console.WriteLine(carObjWithUsing.Name);
            }
        }
    }
}
