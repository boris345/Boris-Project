using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animal_Polimorthism
{
    class Bird:Dog
    {
        public Bird()
        {
            Console.WriteLine("Bird Constructor");
        }
        public override void Talk()
        {
            Console.WriteLine("Bird talk");
        }
        public override void Sing() //
        {
            Console.WriteLine("Bird sing");
        }
    }
}
