using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

public class UnityEventLevel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI levelTxt;
    [SerializeField] TextMeshProUGUI expTxt;
    // Event Action variable use to subscribe the method
    public UnityEvent OnLevelUp;

    private int level = 0;

    private float exp = 0f;
    private float minIncreaseExp = .25f;
    private float maxIncreaseExp = 5f;

    private float nextLevelExp = 10f;

    private void Start()
    {
        StartCoroutine(IncreaseLevelRoutine());
    }

    private IEnumerator IncreaseLevelRoutine()
    {
        while (true)
        {
            exp += Random.Range(minIncreaseExp, maxIncreaseExp);
            //Debug.Log($"Increase Exp : {exp}");

            if (exp >= nextLevelExp)
            {
                exp -= nextLevelExp;
                level += 1;

                Debug.Log($"Level Up to {level}");

                // Invoke the OnLevelUp event
                OnLevelUp?.Invoke();
            }

            UpdateLevelText();

            yield return new WaitForSeconds(3f);
        }
    }

    public void UpdateLevelText()
    {
        levelTxt.text = level.ToString();
        expTxt.text = exp.ToString();
    }
}
