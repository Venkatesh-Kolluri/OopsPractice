using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Oops
{
    internal class Student
    {
        public Student(int id)
        {
            Id = id;
        }
        private int age;
        public string Name;
        public int Id { get; }
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0 && value < 100)
                {
                    age = value;
                }
            }
            
        }
        public static void Main(string[] args)
        {
            Student ashok=new Student(54);
            ashok.Name = "Ashok";
            ashok.Age = 80;

            Student rakesh=new Student(34);
            rakesh.Name = "Rakesh";
            rakesh.Age = 35;


            Console.WriteLine(ashok.Id);
            Console.WriteLine(ashok.Age);

        }
     
    }
}
