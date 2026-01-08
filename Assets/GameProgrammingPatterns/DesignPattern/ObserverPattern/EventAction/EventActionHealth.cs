using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EventAction
{
    public class EventActionHealth : MonoBehaviour
    {
        [SerializeField] Image healthBar;

        private int health = 0;
        private int maxHealth = 100;

        private int minIncreaseHealth = 5;
        private int maxIncreaseHealth = 15;

        // Subscribe Event Action
        private void OnEnable()
        {
            EventActionLevel.OnLevelUp += HealHealth;
            EventActionLevel.OnLevelUp += UpdateHealthBar;
        }

        // Unsubscribe Event Action
        private void OnDisable()
        {
            EventActionLevel.OnLevelUp -= HealHealth;
            EventActionLevel.OnLevelUp -= UpdateHealthBar;
        }

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

        private void HealHealth()
        {
            health = maxHealth;
            Debug.Log($"Heal Health : {health}");
        }

        private void UpdateHealthBar()
        {
            healthBar.fillAmount = health / (float)maxHealth;
        }
    }
}