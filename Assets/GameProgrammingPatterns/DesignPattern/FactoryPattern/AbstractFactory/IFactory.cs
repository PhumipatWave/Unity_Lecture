using UnityEngine;

namespace AbstractFactory
{
    public interface IFactory
    {
        IWeapon CreateWeapon();
        IEnemy CreateEnemy();
    }

    public class SwordUnitFactory : IFactory
    {
        public IEnemy CreateEnemy() => new Knight();
        public IWeapon CreateWeapon() => new Sword();
    }

    public class TankUnitFactory : IFactory
    {
        public IEnemy CreateEnemy() => new TankKnight();
        public IWeapon CreateWeapon() => new Shield();
    }

    public class BowUnitFactory : IFactory
    {
        public IEnemy CreateEnemy() => new Archer();
        public IWeapon CreateWeapon() => new Bow();
    }

    public class BowGunUnitFactory : IFactory
    {
        public IEnemy CreateEnemy() => new HeavyArcher();
        public IWeapon CreateWeapon() => new BowGun();
    }
}