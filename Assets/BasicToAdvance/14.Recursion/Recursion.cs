using UnityEngine;

namespace Recursion
{
    public class Recursion : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log(TestRecursion(0, 5, 1));
        }

        private int TestRecursion(int num, int maxNum, int increaseAmount)
        {
            if (num < maxNum)
            {
                return TestRecursion(num + increaseAmount, maxNum, increaseAmount);
            }
            else
            {
                return num;
            }
        }
    }
}