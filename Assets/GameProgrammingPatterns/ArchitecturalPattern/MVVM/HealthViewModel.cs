using System;

namespace MVVM
{
    public class HealthViewModel
    {
        private HealthModel model;

        public event Action<float> OnHealthChange;

        public HealthViewModel(HealthModel model)
        {
            this.model = model;
        }

        public void Bind()
        {
            NotifyHealthChange();
        }

        public void Damage(int amount)
        {
            model.TakeDamage(amount);
            NotifyHealthChange();
        }

        public void Heal(int amount)
        {
            model.Recovery(amount);
            NotifyHealthChange();
        }

        private void NotifyHealthChange()
        {
            float normalizeHealth = (float)model.CurrentHealth / model.MaxHealth;
            OnHealthChange?.Invoke(normalizeHealth);
        }
    }
}