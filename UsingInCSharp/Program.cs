using System;

namespace UsingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //with using statement
            //Car carObjWithUsing = new Car();
            //using (carObjWithUsing)
            //{
            //    Console.WriteLine(carObjWithUsing.Name);
            //}
            //Console.WriteLine(carObjWithUsing.Name);

          
            using (Car carObjWithUsing1 = new Car(), Animal carObjWithUsing2 = new Animal())
            {
                 
            }
            

        }
    }
}
