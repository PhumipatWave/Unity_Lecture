using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace OtherCollection
{
    public class HashSets : MonoBehaviour
    {
        void Start()
        {
            // HashSet : The Collection that store unique value
            HashSet<string> stringHashSetA = new HashSet<string>();
            stringHashSetA.Add("Player");
            stringHashSetA.Add("Player1");
            stringHashSetA.Add("Player"); // The HashSet ignored the value that had in this collection
            stringHashSetA.Add("Player2");
            stringHashSetA.Add("Player3");

            stringHashSetA.Remove("Player1");

            HashSet<string> stringHashSetB = new HashSet<string>();
            stringHashSetB.Add("Player4");
            stringHashSetB.Add("Player5");

            var union = stringHashSetA.Union(stringHashSetB);
            foreach (var item in union)
            {
                Debug.Log(item);
            }
        }
    }
}