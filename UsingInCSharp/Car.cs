using System;
using System.Collections.Generic;
using System.Text;

namespace UsingInCSharp
{
    public class Car : IDisposable
    {
        public string Name { get; set; } = "Super Car";

        public void Dispose()
        {
            Console.WriteLine("Disposing");
        }
    }
}
