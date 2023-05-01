using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class MethodOverload
    {
        public static void Main(string[] args)
        {
            int a = add(10, 20);
            int b = add(20, 30,40);
            double x = add(1.1, 2.2);
            double y = add(1.1, 2.2, 3.3);

            Console.WriteLine(a); 
            
            Console.WriteLine(b);
            
            Console.WriteLine(x);
            
            Console.WriteLine(y);
        }
        public static int add(int a,int b)
        {
            return a + b;

        }
        public static int add(int a,int b, int c)
        {
            return a + b + c;
        }
        public static double add(double a,double b)
        {
            return a + b;
        }
        public static double add(double a,double b,double c)
        {
            return a + b + c;
        }
    }
}
