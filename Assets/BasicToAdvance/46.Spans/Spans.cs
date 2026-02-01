using System;
using UnityEngine;

namespace Spans
{
    // Span : deal with collection without a memory cost
    public class Spans : MonoBehaviour
    {
        private void Start()
        {
            int[] numberArray = new int[] { 9, 23, 1, 57, 3, 112 };
            //int[] subArray = new int[numberArray.Length - 2];

            // Span : not create any new memory it pointing to original memory
            Span<int> intSpan = new Span<int>(numberArray, 1, 4);
            intSpan.Fill(0);

            foreach (int number in numberArray)
            {
                Debug.Log(number);
            }

            string str = "42,78";
            ReadOnlySpan<char> charSpan = str;
            int number1 = int.Parse(charSpan.Slice(0, 2));
            int number2 = int.Parse(charSpan.Slice(3, 2));
            Debug.Log($"{number1} {number2}");
        }
    }
}