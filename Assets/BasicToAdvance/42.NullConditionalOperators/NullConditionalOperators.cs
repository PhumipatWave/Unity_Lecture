using System;
using System.Collections.Generic;
using UnityEngine;

namespace NullConditionalOperators
{
    public class NullConditionalOperators : MonoBehaviour
    {
        private void Start()
        {
            Player player = new Player();
            Debug.Log(player?.GetPlayerName());
            Debug.Log(player?.playerName);
            player?.target?.TakeDamage();

            List<string> playerNameList = new List<string> { "Test" };
            Debug.Log(playerNameList?[0]);

            List<Player> playerList = new List<Player> { new Player() };
            playerList?[0]?.TakeDamage();

            // Nullable
            int? i = 5;
            i?.ToString();
        }

        public class Player
        {
            public event EventHandler OnDamaged;

            public string playerName;
            public Player target;

            public void TakeDamage()
            {
                // ? : Null Conditional Operators
                // if left is null pass the right side code
                // if left is not null execute the right side code
                OnDamaged?.Invoke(this, EventArgs.Empty);
            }

            public string GetPlayerName()
            {
                return "Test Player";
            }
        }
    }
}