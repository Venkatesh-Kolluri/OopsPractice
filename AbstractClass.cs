using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
   public class AbstractClass 
    {
       /* public static void Main(string[] args)
        {
            ABC abc = new XYZ2();
            abc.connection();
            abc.saveData();

        }*/

       
    }
    public abstract class ABC : A
    {

        public virtual void connection() { }
        public void saveData()
        {
            Console.WriteLine("Data Saved");
        }       

    }
    public class XYZ : ABC
    {
        public override void connection()
        {
            Console.WriteLine("Connection Established wit sql");
        }
    }
    public class XYZ2 : ABC
    {
        public override void connection()
        {
            Console.WriteLine("connection established with MondoDb");
        }
    }
}
