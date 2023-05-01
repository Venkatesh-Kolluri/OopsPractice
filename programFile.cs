using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class Animal
    {       
        public virtual void eat()
        {
            Console.WriteLine("Animal will Eat");
        }
        public virtual void move() 
        {
            Console.WriteLine("Animal Will Move");
        }
        public void breath()
        {
            Console.WriteLine("It Will Breath");
        }
    }
    public class Cow : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Cow chew the Food");
        }
        public override void move()
        {
            Console.WriteLine("Cow will move with four legs");
        }

    }
    public class Snake : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Snake will Swallow ");
        }
        public override void move()
        {
            Console.WriteLine("Snake will crawl");
        }

    }
    public class Program
    {
        static void Main()
        {
            Cow cow = new Cow();
            cow.eat();
            cow.move();
            cow.breath();
            Snake snake = new Snake();
            snake.eat();
            snake.move();
            snake.breath();
        }

    }



}
