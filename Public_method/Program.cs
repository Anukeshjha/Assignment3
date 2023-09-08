using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndquestion
{
    internal class Program
    {
        class MyClassWithPrivateField
        {
            private int myPrivate;

            public MyClassWithPrivateField(int value)
            {
                Console.WriteLine("Enter your value");
                string stringinput = Console.ReadLine();
                myPrivate = int.Parse(stringinput);
            }

            internal int GetPrivateValue()
            {
                return myPrivate;
            }
        }

        class AnotherClass
        {
            public void AccessPrivate()
            {
                MyClassWithPrivateField myObject = new MyClassWithPrivateField(42);
                int privateFieldValue = myObject.GetPrivateValue();
                Console.WriteLine("Accessed private field value: " + privateFieldValue);
            }
        }

        class Pro
        {
            static void Main(string[] args)
            {
                AnotherClass Obj = new AnotherClass();
                Obj.AccessPrivate();
                Console.Read();
            }
        }
    }
}