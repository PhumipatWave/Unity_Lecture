using UnityEngine;

namespace Polymorphism
{
    public abstract class Character : MonoBehaviour, IDamageable
    {
        public int health;
        public int speed;

        protected abstract void Initialize();
        protected abstract void Attack<T>(T target) where T : Character;

        protected void Awake()
        {
            Initialize();
        }

        public virtual void TakeDamage(int damage)
        {
            health -= damage;
        }

        // Overload
        private void SetStat(int health)
        {
            this.health = health;
        }

        private void SetStat(int health, int speed)
        {
            this.health = health;
            this.speed = speed;
        }
    }
}