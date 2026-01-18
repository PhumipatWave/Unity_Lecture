using Unity.VisualScripting;
using UnityEngine;

namespace SRP
{
    // Single Responsibility Principle (SRP)
    // "A class should only have one reason to change"

    // Bad
    /*public class Player : MonoBehaviour
    {
        private void Move() { }
        private void Jump() { }
        private void Dash() { }
        private void Attack() { }
        private void Interact() { }
        public void SoundManager { }
        public void AnimationManager { }
    }*/

    // Good
    // Split the system to groups
    // Not all the system should use MonoBehaviour
    // Use MonoBeharvior when want to use Unity lifecycle (Awake, Start, Update, OnTrigger, SerializeField)
    public class Player : MonoBehaviour
    {
        private PlayerMovement movement;
        private PlayerCombat combat;
        private PlayerInteraction interaction;
        public SoundManager soundManager;
        public AnimationManager animationManager;

        private void Awake() { }
        private void Update() { }
    }

    public class PlayerMovement
    {
        public void Move() { }
        public void Jump() { }
        public void Dash() { }
    }

    public class PlayerCombat
    {
        public void Attack() { }
    }

    public class PlayerInteraction
    {
        public void Interact() { }
    }

    public class AnimationManager
    {
        public void PlayAnimation() { }
    }

    public class SoundManager
    {
        public void PlaySound() { }
        public void StopSound() { }
    }
}