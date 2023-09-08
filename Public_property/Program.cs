using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6thquestion
{
    //Create a class with a public property. Derive another class and try to access the property.

    public class BaseClass
    {

        public string MyProperty { get; set; }
    }


    public class DerivedClass : BaseClass
    {
        public void PropertyAccess()
        {
            Console.WriteLine("Value of MyProperty in the derived class: " + MyProperty);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            DerivedClass derivedObj = new DerivedClass();


            derivedObj.MyProperty = "Hello, World!";


            derivedObj.PropertyAccess();

            Console.Read();
        }
    }

}
