using System;
using UnityEngine;

namespace Factory
{
    public class WeaponCreator : MonoBehaviour
    {
        void Start()
        {
            IWeapon weapon1 = WeaponFactory.Create(WeaponType.Melee);
            weapon1.Attack();

            IWeapon weapon2 = WeaponFactory.Create(WeaponType.Range);
            weapon2.Attack();

            IWeapon weapon3 = WeaponFactory.Create(WeaponType.Special);
            weapon3.Attack();

            /*foreach (WeaponType type in Enum.GetValues(typeof(WeaponType)))
            {
                IWeapon weapon = WeaponFactory.Create(type);
                weapon.Attack();
            }*/
        }
    }
}