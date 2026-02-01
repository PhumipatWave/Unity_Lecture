using System;
using UnityEngine;

namespace EnumFlags
{
    // Enum Flags : Work with enum as a bitmask
    // Can set the enum type to int, byte or something to reduct used memory
    [Flags]
    public enum Ability : byte
    {
        None = 0,
        Jump = 1 << 0,
        Sprint = 1 << 1,
        Shoot = 1 << 2,
        Fly = 1 << 3,

        /*Fly2 = 1 << 4,
        Fly3 = 1 << 5,
        Fly4 = 1 << 6,
        Fly5 = 1 << 7,*/

        //Can't use
        //Fly6 = 1 << 8

        //Can use bitwise operators in enum
        ShootAndFly = Shoot | Fly
    }

    public class EnumFlag : MonoBehaviour
    {
        private void Start()
        {
            Ability playerAbilities = Ability.Jump | Ability.Shoot;
            Debug.Log(playerAbilities);

            // Check is has a Jump ability
            Debug.Log(playerAbilities.HasFlag(Ability.Jump));

            // (Ability.Jump & playerAbilities) : get the jump ability bitwise
            Debug.Log((Ability.Jump & playerAbilities) == Ability.Jump);
        }
    }
}