using UnityEngine;

namespace NestedLoop
{
    public class NestedLoop : MonoBehaviour
    {
        void Start()
        {
            int[,] intArray = new int[3, 2];

            for (int i = 0; i < intArray.GetLength(0); i++)
            {
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    Debug.Log($"{i}, {j}");
                    //break;

                    if (i == 0)
                    {
                        // Skip the below code and continue run
                        continue;
                    }
                    Debug.Log("Test");
                }
            }
        }
    }
}