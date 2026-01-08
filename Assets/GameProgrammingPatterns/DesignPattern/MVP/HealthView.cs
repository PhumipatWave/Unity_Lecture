using System;
using UnityEngine;
using UnityEngine.UI;

namespace MVP
{
    public class HealthView : MonoBehaviour, IHealthView
    {
        [SerializeField] private Image healthBar;

        public event Action OnDamageClick;
        public event Action OnHealClick;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                OnDamageClick?.Invoke();
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                OnHealClick?.Invoke();
            }
        }

        public void UpdateHealth(int current, int max)
        {
            healthBar.fillAmount = (float)current / max;
            Debug.Log($"Health = {current}");
        }
    }
}