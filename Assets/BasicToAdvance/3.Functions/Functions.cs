using UnityEngine;

namespace Functions
{
    public class Functions : MonoBehaviour
    {
        private void Start()
        {
            DebugMessage("Hello World");
        }

        void DebugMessage(string debug)
        {
            Debug.Log(debug);
        }
    }
}