using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_12
{
    class Weapon
    {
        public string Name;

        public void Label()
        {
            Console.WriteLine("This is {0}", Name);
        }
    }
}
