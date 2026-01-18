using System.Collections.Generic;
using UnityEngine;

namespace OtherCollection
{
    public class Sorteds : MonoBehaviour
    {
        void Start()
        {
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(1);
            sortedSet.Add(3);
            sortedSet.Add(2);
            sortedSet.Add(1); // ignored
            sortedSet.Add(0);

            foreach (int set in sortedSet)
            {
                Debug.Log(set);
            }

            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(2, "B");
            sortedList.Add(0, "x");
            sortedList.Add(1, "A");

            foreach (var list in sortedList)
            {
                Debug.Log($"{list.Key} : {list.Value}");
            }

            SortedDictionary<string, int> sortedDictionary = new SortedDictionary<string, int>();
            sortedDictionary.Add("C", 3);
            sortedDictionary.Add("A", 1);
            sortedDictionary.Add("B", 2);

            foreach (var dictionary in sortedDictionary)
            {
                Debug.Log($"{dictionary.Key} : {dictionary.Value}");
            }
        }
    }
}