using System.Collections.Generic;
using UnityEngine;

namespace ArrayList
{
    public class ArrayList : MonoBehaviour
    {
        private void Start()
        {
            // Array
            int[] numArray = new int[3] { 10, 2, 5 };
            //int[] numArray = new int[] { 10, 2, 5 };
            numArray[2] = 3;
            Debug.Log($"Array length : {numArray.Length}, Index 2 : {numArray[2]}");

            // List
            List<int> numList = new List<int>();
            numList.Add(20);
            numList.Add(1);
            //numList.Remove(20);
            //numList.RemoveAt(1);
            Debug.Log($"Array length : {numArray.Length}, Index 2 : {numArray[0]}");
        }
    }
}