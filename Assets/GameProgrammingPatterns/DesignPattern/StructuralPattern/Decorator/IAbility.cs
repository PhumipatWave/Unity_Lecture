using UnityEngine;

namespace Decorator
{
    public interface IAbility
    {
        void Use();
    }

    // Decorator pattern
    // Use for add the extra behavior that used together of this behavior
    public class DecoratorBehavior : IAbility
    {
        private IAbility wrappedAbility;

        public DecoratorBehavior(IAbility wrappedAbility)
        {
            this.wrappedAbility = wrappedAbility;
        }

        public void Use()
        {
            // Do the extra behavior or stack the effect of this behavior
            wrappedAbility.Use();
            Debug.Log("Run the extra effect from Decorator");
        }
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