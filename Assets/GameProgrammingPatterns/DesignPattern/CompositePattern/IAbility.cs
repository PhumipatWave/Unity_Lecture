using UnityEngine;

namespace Composite
{
    public interface IAbility
    {
        void Use();
    }

    // Composite pattern
    // Use for run a multiple beharvior in once time
    public class SequenceComposite : IAbility
    {
        // Array of behavior
        private IAbility[] children;

        public SequenceComposite(IAbility[] children)
        {
            this.children = children;
        }

        public void Use() 
        {
            foreach (var child in children)
            {
                child.Use();
            }
        }
    }

    public class DecoratorBehavior : IAbility
    {
        private IAbility wrappedAbility;

        public DecoratorBehavior(IAbility wrappedAbility)
        {
            this.wrappedAbility = wrappedAbility;
        }

        public void Use()
        {
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