using UnityEngine;

namespace Factory
{
    public class WeaponFactory : MonoBehaviour
    {
        public static IWeapon Create(WeaponType type)
        {
            return type switch
            {
                WeaponType.Melee => new Melee(),
                WeaponType.Range => new Range(),
                WeaponType.Special => new Special(),
                _ => null
            };
        }
    }
}