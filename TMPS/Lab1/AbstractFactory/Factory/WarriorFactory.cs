using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factory
{
    internal class WarriorFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Sword();
        }
    }
}