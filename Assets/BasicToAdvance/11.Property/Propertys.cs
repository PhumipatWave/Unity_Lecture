using System;
using UnityEngine;

namespace Propertys
{
    public class Propertys : MonoBehaviour
    {
        #region PropertyExample1
        // Property not a variable, not store any data
        /*private string playerName;
        public string PlayerName 
        {
            get 
            {
                if (playerName == null) return "Unknown";
                return playerName; 
            }
            private set 
            {
                if (value == "Player 1")
                {
                    throw new Exception("Can't use name : Player 1");
                }
                playerName = value; 
            }
        }
        
        void Start()
        {
            PlayerName = "Player 1";
            Debug.Log(PlayerName);
        }*/
        #endregion

        #region PropertyExample2
        private string playerName;

        private void SetPlayerName(string playerName)
        {
            this.playerName = playerName; 
        }

        private string GetPlayerName()
        {
            return playerName;
        }
        #endregion
    }
}