using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UnityEvents
{
    public class UnityEventHealth : MonoBehaviour
    {
        [SerializeField] Image healthBar;

        private int health = 0;
        private int maxHealth = 100;

        private int minIncreaseHealth = 5;
        private int maxIncreaseHealth = 15;

        private void Start()
        {
            HealHealth();
            StartCoroutine(DecreaseHealthRoutine());
        }

        private IEnumerator DecreaseHealthRoutine()
        {
            while (true)
            {
                health -= Random.Range(minIncreaseHealth, maxIncreaseHealth);
                Debug.Log($"Decrease Health : {health}");

                UpdateHealthBar();

                yield return new WaitForSeconds(1.5f);
            }
        }

        public void HealHealth()
        {
            health = maxHealth;
            Debug.Log($"Heal Health : {health}");
        }

        public void UpdateHealthBar()
        {
            healthBar.fillAmount = health / (float)maxHealth;
        }
    }
}