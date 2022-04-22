using AbstractFactory.Movements;
using AbstractFactory.Weapons;

namespace AbstractFactory.Factory
{
    internal abstract class HeroFactory
    {
        public abstract Movement CreateMovement();

        public abstract Weapon CreateWeapon();
    }
}