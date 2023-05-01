using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public interface A
    {
        void connection();
        void saveData();

    }
    public class B : A
    {

        public void connection()
        {
            Console.WriteLine("Connection Established with Sql");
        }
       public void saveData()
        {
            Console.WriteLine("Data Saved");
        }
  
    }
    public class C : A
    {
        public void connection()
        {
            Console.WriteLine("Connection Established with MongoDb");
        }
        public void saveData()
        {
            Console.WriteLine("Data Saved");
        }
    }
    public class Abstraction
    {
        public static void Main(string[] arg)
        {
            A a = new C();
            a.connection();
            a.saveData();
        }
    }
  
}
