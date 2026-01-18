using System.Collections.Generic;
using UnityEngine;

namespace OtherCollection
{
    public class Queues : MonoBehaviour
    {
        void Start()
        {
            // First In First Out
            Queue<string> stringQueue = new Queue<string>();
            stringQueue.Enqueue("Player");
            stringQueue.Enqueue("New Player");
            stringQueue.Enqueue("Last Player");

            Debug.Log(stringQueue.Dequeue());
        }
    }
}