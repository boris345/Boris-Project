using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Polimorthism
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }
        public virtual void Greet()
        {
            Console.WriteLine("Animal says hello");
        }
        public virtual void Talk()
        {
            Console.WriteLine("Animal talk");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal sing");
        }
    }
}
