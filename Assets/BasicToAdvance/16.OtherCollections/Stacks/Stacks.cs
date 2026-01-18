using System.Collections.Generic;
using UnityEngine;

namespace OtherCollection
{
    public class Stacks : MonoBehaviour
    {
        void Start()
        {
            // First In Last Out
            Stack<string> nameStack = new Stack<string>();
            nameStack.Push("Player");
            nameStack.Push("New Player");
            nameStack.Push("Last Player");

            Debug.Log($"Pop : {nameStack.Pop()}\nPeek : {nameStack.Peek()}");
        }
    }
}