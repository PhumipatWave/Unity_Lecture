using UnityEngine;

public class DelegateEnemy : MonoBehaviour
{
    void Start()
    {
        DelegateMessage.onMessage("Enemy Delegate");
    }
}
