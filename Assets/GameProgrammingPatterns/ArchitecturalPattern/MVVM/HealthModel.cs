using System;

namespace MVVM
{
    public class HealthModel
    {
        public int MaxHealth { get; }
        public int CurrentHealth { get; private set; }

        public HealthModel(int maxHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
        }

        public void TakeDamage(int amount)
        {
            CurrentHealth = Math.Max(0, CurrentHealth - amount);
        }

        public void Recovery(int amount)
        {
            CurrentHealth = Math.Min(MaxHealth, CurrentHealth + amount);
        }
    }
}