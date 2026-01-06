using System;
using UnityEngine;

public class DelegatePlayer : MonoBehaviour
{
    void Start()
    {
        DelegateMessage.onMessage("Player Delegate");
    }
}
