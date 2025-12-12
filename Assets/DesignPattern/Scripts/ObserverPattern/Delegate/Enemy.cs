using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Start()
    {
        DelegateMessage.onMessage("Enemy Delegate");
    }
}
