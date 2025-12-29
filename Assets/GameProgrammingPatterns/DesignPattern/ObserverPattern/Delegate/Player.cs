using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
        DelegateMessage.onMessage("Player Delegate");
    }
}
