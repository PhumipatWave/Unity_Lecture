using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] Image healthBar;

    private int health = 0;
    private int maxHealth = 100;

    private int minIncreaseHealth = 5;
    private int maxIncreaseHealth = 15;

    // Subscribe Event Action
    private void OnEnable()
    {
        Level.OnLevelUp += HealHealth;
        Level.OnLevelUp += UpdateHealthBar;
    }

    // Unsubscribe Event Action
    private void OnDisable()
    {
        Level.OnLevelUp -= HealHealth;
        Level.OnLevelUp -= UpdateHealthBar;
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
    }

    private void UpdateHealthBar()
    {
        healthBar.fillAmount = (float)health / (float)maxHealth; 
        //Debug.Log($"Health FillAmount : {(float)health / (float)maxHealth}");
    }
}
