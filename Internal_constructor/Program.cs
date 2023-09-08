//internal cunstructor class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10question
{
    internal class cunstructor
    {
        private int x;
        internal cunstructor(int a)
        {
            this.x = a;
            x++;
            x++;
            Console.WriteLine("internal cunstructor :" + x);

        }
    }
}



namespace _10question
{
    internal class Program
    {
        static void Main(string[] args)
        {
            cunstructor inst = new cunstructor(25);
            Console.ReadKey();

        }
    }
}
