namespace MVP
{
    // Presenter : Connect the Model and View
    public class HealthPresenter
    {
        private HealthModel model;
        private IHealthView view;

        public HealthPresenter(HealthModel model, IHealthView view)
        {
            this.model = model;
            this.view = view;

            view.OnDamageClick += TakeDamage;
            view.OnHealClick += Heal;

            model.OnHealthChange += UpdateView;

            view.UpdateHealth(model.CurrentHealth, model.MaxHealth);
        }

        public void TakeDamage()
        {
            model.TakeDamage(25);
        }

        public void Heal()
        {
            model.Heal(10);
        }

        private void UpdateView(int current, int max)
        {
            view.UpdateHealth(current, max);
        }

        public void Dispose()
        {
            view.OnDamageClick -= TakeDamage;
            view.OnHealClick -= Heal;
            model.OnHealthChange -= UpdateView;
        }
    }
}