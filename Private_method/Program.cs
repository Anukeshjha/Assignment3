using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8thqueston
{
    class que
    {

        private void Method1()
        {
            Console.WriteLine("This is a private method.");
        }


        public void Method2()
        {
            Console.WriteLine("This is a public method.");
            Method1();
        }
    }

    class Program
    {
        static void Main()
        {

            que Obj = new que();


            Obj.Method2();
            Console.Read();

        }
    }
}