using System;

namespace MVP
{
    public interface IHealthView
    {
        event Action OnDamageClick;
        event Action OnHealClick;

        void UpdateHealth(int current, int max);
    }
}