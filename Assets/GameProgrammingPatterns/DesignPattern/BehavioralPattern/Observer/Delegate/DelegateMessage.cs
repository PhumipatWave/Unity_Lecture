using UnityEngine;

namespace Delegate
{
    public class DelegateMessage : MonoBehaviour
    {
        // Impletement delegate void and has parameter type in
        // the same of method that it want to use this delegate
        public delegate void MyDelegateMessage(string message);

        // Impletement variable from delegate void
        // to use to call the delegate
        public static MyDelegateMessage onMessage;

        // Subscribe method to the delegate
        void OnEnable()
        {
            onMessage += PrintMessage;
        }

        // Normal method with the same parameter type with delegate
        private void PrintMessage(string text)
        {
            Debug.Log($"Message : {text}");
        }
    }
}