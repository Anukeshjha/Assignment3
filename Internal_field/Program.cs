// internal class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thirdquestion
{
    internal class internalclass
    {
        internal int x;
        internal void method()
        {
            Console.WriteLine("internal class is accessed");
            Console.WriteLine("internal class variable have value: " + x);
        }
    }
}






namespace thirdquestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            internalclass inti = new internalclass();
            inti.x = 45;

            Console.WriteLine("Main class got access the other internal class");
            inti.method();
            Console.Read();
        }
    }
}