using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Derived : Base
    {
        public override void show()
        {
            Console.WriteLine("Derived Class");
        }
    }
}
