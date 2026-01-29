using System;
using UnityEngine;

namespace LocalFunctionAndLamda
{
    public class LocalFunction_Lamba : MonoBehaviour
    {
        private void Start()
        {
            // Lamda : assign at the run time it create new object every time on whis function call
            Action<string> action = (string message) => {
                Debug.Log(message);
            };

            // Local Function : create once time on this script enable
            void Print(string message)
            {
                Debug.Log(message);
            }
            Action<string> myAction2 = Print;
        }
    }
}