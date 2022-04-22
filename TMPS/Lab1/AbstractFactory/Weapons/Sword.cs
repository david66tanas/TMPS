using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Weapons
{
    internal class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Palim cu sabia");
        }
    }
}