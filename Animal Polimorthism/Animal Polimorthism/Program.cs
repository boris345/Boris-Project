using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Polimorthism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Dog(); //     Dog  פנייה למחלקת 
            animal.Talk();
            animal.Sing();
            animal.Greet();

            Console.WriteLine();

            Dog dog = new Dog();
            dog.Talk();
            dog.Sing();
            dog.Greet();

            Console.WriteLine();

            Animal animal2 = new Bird();
            animal2.Talk();
            animal2.Sing();

            Console.ReadKey();
        }
    }
}
