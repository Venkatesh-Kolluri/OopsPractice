using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Oops
{
    public class Parent
    {
        public Parent(int parentAge)
        {
           
            Console.WriteLine("Parent object got created "+ parentAge);
        }
       
    }
    public class Child : Parent
    {
        public Child(int parentAge,int childAge) : base(parentAge)
        {
           

            Console.WriteLine("Child class got created "+ childAge);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child(50, 25);
            Console.WriteLine(child);

        }
    }
}
