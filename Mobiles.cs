using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Oops
{
    public class Mobile
    {
        public void mobiles()
        {
            Console.WriteLine("Mobile is of Android");
        }
        public void samsung()
        {
            Console.WriteLine("Name of the mobile company is Samsung");
        }

    }
    public class Samsung1 : Mobile
    {
        public void storage()
        {
            Console.WriteLine("The Storage capacity is 64GB");
        }
        public void version()
        {
            Console.WriteLine("The version of mobile is S1");
        }
        public void Price()
        {
            Console.WriteLine("Mobile price is 12000 rupees");
        }
    }
    public class Samsung2 : Mobile
    {
        public void storage()
        {
            Console.WriteLine("The Storage capacity is 128GB");
        }
        public void version()
        {
            Console.WriteLine("The version of mobile is S2");
        }
        public void Price()
        {
            Console.WriteLine("Mobile price is 15000 rupees");
        }
    }

    public class Samsung3 : Mobile
    {
        public void storage()
        {
            Console.WriteLine("The Storage capacity is 128GB");
        }
        public void version()
        {
            Console.WriteLine("The version of mobile is S2_pro");
        }
        public void Price()
        {
            Console.WriteLine("Mobile price is 18000 rupees");
        }
    }

    public class S1 : Samsung1
    {
        public void flipkart()
        {
            Console.WriteLine("Mobile is available in Flipkart");
        }
    }
    public class S2 : Samsung2
    {
        public void amazon()
        {
            Console.WriteLine("Mobile is available in Amazon");
        }
    }
    public class S2_Pro : Samsung3
    {
        public void flipkart()
        {
            Console.WriteLine("Mobile is available in Flipkart");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            S1 s1 = new S1();
            s1.samsung();
            s1.storage();
            s1.version();
            s1.Price();
            s1.flipkart();
            s1.GetHashCode();

            Console.WriteLine("=================================================");
            S2 s2 = new S2();
            s2.samsung();
            s2.storage();
            s2.version();
            s2.Price();
            s2.amazon();
            Console.WriteLine("=================================================");

            S2_Pro s2_Pro = new S2_Pro();
            s2_Pro.samsung();
            s2_Pro.storage();
            s2_Pro.version();
            s2_Pro.Price();
            s2_Pro.flipkart();
            Console.WriteLine("=================================================");
        }

    }
}

