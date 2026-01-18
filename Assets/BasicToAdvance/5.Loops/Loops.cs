using UnityEngine;

namespace Loops
{
    public class Loops : MonoBehaviour
    {
        void Start()
        {
            // while
            int i = 0;
            while (i < 5)
            {
                Debug.Log($"While loop {i}");
            }

            // do while
            do
            {
                Debug.Log($"Do while {i}");
                i++;
            }
            while (i < 5);

            // for
            for (int j = 0; j < 5; j++)
            {
                Debug.Log($"for {i}");
            }

            // foreach
            string[] nameArray = new string[]
            {
                "A",
                "B",
                "C"
            };

            foreach (string name in nameArray)
            {
                Debug.Log($"{name}");
            }
        }
    }
}