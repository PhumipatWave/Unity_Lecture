using UnityEngine;

namespace AbstractFactory
{
    public interface IWeapon
    {
        public void Use();
    }

    public class Sword : IWeapon
    {
        public void Use() => Debug.Log("Sword used");
    }

    public class Shield : IWeapon
    {
        public void Use() => Debug.Log("Shield used");
    }

    public class Bow : IWeapon
    {
        public void Use() => Debug.Log("Bow used");
    }

    public class BowGun : IWeapon
    {
        public void Use() => Debug.Log("BowGun used");
    }
}