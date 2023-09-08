using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9thqueston
{
    class Base
    {
        protected void ProMethod()
        {
            Console.WriteLine("This is a protected method in the base class.");
        }
    }


    class Derived : Base
    {
        public void Access()
        {
            Console.WriteLine("Calling protected method from derived class:");
            ProMethod();
        }
    }

    internal class Program
    {
        static void Main()
        {
            Derived dObj = new Derived();
            dObj.Access();
            Console.Read();
        }
    }
}