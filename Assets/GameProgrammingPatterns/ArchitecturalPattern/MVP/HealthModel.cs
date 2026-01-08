using System;

namespace MVP
{
    public class HealthModel
    {
        public int MaxHealth { get; }
        public int CurrentHealth { get; private set; }

        public event Action<int, int> OnHealthChange;

        public HealthModel(int maxHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
        }

        public void TakeDamage(int amount)
        {
            CurrentHealth = Math.Max(0, CurrentHealth - amount);
            OnHealthChange?.Invoke(CurrentHealth, MaxHealth);
        }

        public void Heal(int amount)
        {
            CurrentHealth = Math.Min(MaxHealth, CurrentHealth + amount);
            OnHealthChange?.Invoke(CurrentHealth, MaxHealth);
        }
    }
}