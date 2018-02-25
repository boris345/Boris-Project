using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Polimorthism
{
    class Dog:Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor");
        }
        public new virtual void Talk() //             בקשה להתעלם מהדרישה במחלקה הנוכחית
        {
            Console.WriteLine("Dog talk");
        }
        public override void Sing()
        {
            Console.WriteLine("Dog sing");
        }
    }
}
