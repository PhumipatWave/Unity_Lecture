using System;
using System.Collections;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class EventActionLevel : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI levelTxt;
    [SerializeField] TextMeshProUGUI expTxt;
    // Event Action variable use to subscribe the method
    public static event Action OnLevelUp;

    private int level = 0;

    private float exp = 0f;
    private float minIncreaseExp = .25f;
    private float maxIncreaseExp = 5f;

    private float nextLevelExp = 10f;

    // Subscribe Event Action
    private void OnEnable()
    {
        OnLevelUp += UpdateLevelText;
    }

    // Unsubscribe Event Action
    private void OnDisable()
    {
        OnLevelUp -= UpdateLevelText;
    }

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

    private void UpdateLevelText()
    {
        levelTxt.text = level.ToString();
        expTxt.text = exp.ToString();
    }
}
