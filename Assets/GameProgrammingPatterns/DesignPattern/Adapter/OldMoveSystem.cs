using UnityEngine;

namespace Adapter
{
    // Adaptee : The existing class with different interface (Old system)
    public class OldMoveSystem
    {
        public void MoveAction()
        {
            Debug.Log("Old Movement");
        }
    }
}