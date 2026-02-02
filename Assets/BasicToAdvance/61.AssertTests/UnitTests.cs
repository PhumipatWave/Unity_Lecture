using System;
using UnityEngine;

namespace UnitTests
{
    public class UnitTests : MonoBehaviour
    {
        private void Start()
        {
            // Test
            try
            {
                Player player = new Player(null);
                player.GetPlayerNameLength();

                Debug.Log("Test succeeded");
            }
            catch (Exception e)
            {
                Debug.Log("Test failed");
            }
        }

        // Unit : A piece of code that validates another piece of code
        public class Player
        {
            private string playerName;

            public Player(string playerName)
            {
                if (playerName == null)
                {
                    playerName = "";
                }
                this.playerName = playerName;
            }

            public int GetPlayerNameLength()
            {
                return playerName.Length;
            }
        }
    }
}