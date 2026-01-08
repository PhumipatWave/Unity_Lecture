using System;
using UnityEngine;

namespace Delegate
{
    public class DelegatePlayer : MonoBehaviour
    {
        void Start()
        {
            DelegateMessage.onMessage("Player Delegate");
        }
    }
}