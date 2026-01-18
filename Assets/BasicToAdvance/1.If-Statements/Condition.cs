using UnityEngine;

namespace Condition
{
    public class Condition : MonoBehaviour
    {
        private bool isTrue;

        private void Start()
        {
            if (isTrue)
            {
                Debug.Log("True");
            }
            else
            {
                Debug.Log("False");
            }
        }
    }
}