using System;
using UnityEngine;

namespace Nullable
{
    public class Nullable : MonoBehaviour
    {
        private void Start()
        {
            // Reference type can be null
            Player player = null;

            // Value type it can't be null
            // But can used type? : to mark it to nullable
            int? i = null;
            Debug.Log(i.GetValueOrDefault(24));
            if (i.HasValue)
            {
                int attackDamage = i.Value;
            }

            bool? b = null;
            Data? data = null;

            // Second way to make Nullable
            Nullable<int> j = null;

            int? a = null;
            int x = a ?? 20;
        }

        public class Player 
        {
            // Use Nullable if want attackDamage to not be able to damage when not equipe weapon
            public int? attackDamage = null;

            public void Setup(int? startingHealth = null) { }
        }

        public struct Data { }
    }
}