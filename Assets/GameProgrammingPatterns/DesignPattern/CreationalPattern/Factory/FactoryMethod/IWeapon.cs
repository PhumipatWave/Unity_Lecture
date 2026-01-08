using UnityEngine;

namespace FactoryMethod
{
    public interface IWeapon
    {
        public void Attack();
    }

    public class Melee : IWeapon
    {
        public void Attack() => Debug.Log("Melee attack");
    }

    public class Range : IWeapon
    {
        public void Attack() => Debug.Log("Range attack");
    }

    public class Special : IWeapon
    {
        public void Attack() => Debug.Log("Special attack");
    }
}