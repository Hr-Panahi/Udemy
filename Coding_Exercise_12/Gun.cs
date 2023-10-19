using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Exercise_12
{
    class Gun : Weapon, IShootable
    {
        public Gun()
        {
            Name = "Gun";
        }
        public void Shoot()
        {
            Console.WriteLine("Bang!");
        }

    }
}
