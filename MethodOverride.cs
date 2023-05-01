using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    internal class MethodOverride
    {
        public static void Main(string[] args)
        {
            Addition addition = new Addition();
            
            Console.WriteLine(addition.add(20, 30));

            Addition2 addition2 = new Addition2();

            Console.WriteLine(addition2.add(20,30));

        }
    }
    public class Addition
    {
        public virtual int add(int a, int b)
        { 
            return a + b;

        }
    }
    public class Addition2:Addition
    {
        public override int add(int a, int b)
        {
            return a - b;
        }
    }
}
