using UnityEngine;

namespace Strategy
{
    public interface IAbility
    {
        void Use();
    }

    public class NormalAbility : IAbility
    {
        public void Use()
        {
            Debug.Log("Activate Normal ability");
        }
    }

    public class RageAbility : IAbility
    {
        public void Use()
        {
            Debug.Log("Activate Rage ability");
        }
    }

    public class FireballAbility : IAbility
    {
        public void Use()
        {
            Debug.Log("Activate Fireball ability");
        }
    }

    public class HealAbility : IAbility
    {
        public void Use()
        {
            Debug.Log("Activate Heal ability");
        }
    }
}