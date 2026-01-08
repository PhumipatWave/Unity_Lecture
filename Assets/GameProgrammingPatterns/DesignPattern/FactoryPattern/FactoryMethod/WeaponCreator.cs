using UnityEngine;

namespace FactoryMethod
{
    public class WeaponCreator : MonoBehaviour
    {
        // Factory Method : Good for plugin / mods
        // Has many class, Over kill for small system
        void Start()
        {
            WeaponFactory factory = new MeleeFactory();
            IWeapon weapon = factory.CreateWeapon();
            weapon.Attack();
        }
    }
}