using UnityEngine;

namespace Delegate
{
    public class DelegateEnemy : MonoBehaviour
    {
        void Start()
        {
            DelegateMessage.onMessage("Enemy Delegate");
        }
    }
}