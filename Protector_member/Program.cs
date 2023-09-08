using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourthquestion
{
    class MyBaseClass
    {
        protected int ab;

    protected void MyProtectedMethod()
    {
        Console.WriteLine("MyProtectedMethod from MyBaseClass");
    }
}

class MyDerivedClass : MyBaseClass
{
    public void AccessProtectedMembers()
    {
       ab = 42;
        Console.WriteLine($"Accessed myProtectedField from MyDerivedClass: {ab}");

        MyProtectedMethod();
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyDerivedClass obj = new MyDerivedClass();
        obj.AccessProtectedMembers();
            Console.Read();
    }
}
}