using UnityEngine;

namespace FactoryMethod
{
    public abstract class WeaponFactory
    {
        public abstract IWeapon CreateWeapon();
    }

    public class MeleeFactory : WeaponFactory
    {
        public override IWeapon CreateWeapon()
        {
            return new Melee();
        }
    }

    public class RangeFactory : WeaponFactory
    {
        public override IWeapon CreateWeapon()
        {
            return new Range();
        }
    }

    public class SpecialFactory : WeaponFactory
    {
        public override IWeapon CreateWeapon()
        {
            return new Special();
        }
    }
}