using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Event Action variable use to subscribe the method
    public static event Action OnGameStart;

    void Update()
    {
        //StartCoroutine(GameRoutine());
    }

    private IEnumerator GameRoutine()
    {
        // Invoke the OnGameStart event
        OnGameStart?.Invoke();
        yield return new WaitForSeconds(3f);
    }
}
