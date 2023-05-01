using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Oops
{
    internal class RunTime
    {
        public static void Main(string[] args)
        {
            childMath math = new childMath();
            math.Add(12, 23);
            math.Add(1, 2, 3);

            Math math1 = new childMath();
            math1.Add(1, 2);
            //math1.Add(2, 3, 4); //cannot access the numbers of child class once upcasted, to get accesed we need to down caste
           
        } 
        public class Math
        {
            public virtual int Add(int x, int y)
            {
                Console.WriteLine("Parent Logic");
                return 12;
            }
        }
        public class childMath : Math
        {
            public override int Add(int x, int y)
            {
                Console.WriteLine("Child Logic");
                return 34;
            }
            public int Add(int x,int y, int z)
            {
                Console.WriteLine("Child Logic 2");
                return x+y+z;
            }
         
        }
    }
}
