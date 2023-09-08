//internal protected class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fifthquestion
{
    internal class internalprotected
    {
        internal protected int ab;

        internal void method()
        {
            ab++;
            ab++;
            Console.WriteLine("internal class accessed");
            Console.WriteLine(ab);

        }
    }
}








// main class which accessing internal's protected variable 

namespace fifthquestion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            internalprotected obj = new internalprotected();
            string x = Console.ReadLine();
            obj.ab = int.Parse(x);
            obj.method();
            Console.Read();
        }
    }
}