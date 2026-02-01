using System;
using System.Collections.Generic;
using UnityEngine;

namespace NullCoalescingOperator
{
    // Null Coalescing Operator :test if object is null, if so, assign or return a specific value
    public class NullCoalescingOperator : MonoBehaviour
    {
        private string playerName;

        private void Start()
        {
            int playerNameLenght;

            string defaultPlayerName = "DEFAULT";

            // ?? : if left side not null retrun left value
            // if left is null return right value
            playerNameLenght = GetStringLength(playerName ?? defaultPlayerName ?? "");
            playerNameLenght = GetStringLength(playerName ?? throw new Exception($"{nameof(playerName)} is null"));

            // Normaly way
            /*if (playerName == null)
            {
                playerNameLenght = GetStringLength("");
            }
            else
            {
                playerNameLenght = GetStringLength(playerName);
            }*/

            Player player = null;
            // ??= : if player null set player => new Player();
            player ??= new Player();
            Debug.Log(player.ToString());

            Debug.Log(player?.GetPlayerName() ?? "Unkown Player");

            // Nullable
            int? i = 12;
            int b = i ?? 9;
        }

        private int GetStringLength(string str)
        {
            return str.Length;
        }

        public class Player
        {
            private List<Player> playerTargetList;

            public void AddTargetPlayer(Player targetPlayer)
            {
                // ??= : use for initializetion
                playerTargetList ??= new List<Player>();
                playerTargetList.Add(targetPlayer);
            }

            public string GetPlayerName()
            {
                return "";
            }
        }
    }
}