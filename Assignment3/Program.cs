using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3rd
{
    internal class Program
    {
        class MyClass
        {
            private int myPrivate;

            public void Set_Private_Value(int value)
            {
                myPrivate = value;
            }

            public int Get_Private_Value()
            {
                Console.WriteLine("Enter your value");
                string st = Console.ReadLine();
                myPrivate = int.Parse(st);
                return myPrivate;
            }
        }

        class Pro
        {
            static void Main(string[] args)
            {
                MyClass myObject = new MyClass();

                myObject.Set_Private_Value(42);
                Console.WriteLine("Private value is " + myObject.Get_Private_Value());
                Console.Read();
            }
        }
    }
}