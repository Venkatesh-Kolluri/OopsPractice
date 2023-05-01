using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Oops
{
    internal class Inheritance
    {
       /* public static void Main(string[] args)
        {
           // parent p =new parent();
           child1 p1 = new child1();
            //child2 p2 = new child2();

        }*/
        
    }

    public class parent
    {
       public int a = 10;
        public parent()
        {
            Console.WriteLine("I am parent Class");
        }
    }
    public class child1 : parent
    {
        public int a = 200;
        public child1()
        {
            Console.WriteLine("I am child1 class");
            Console.WriteLine(a);
        }
    }
}
