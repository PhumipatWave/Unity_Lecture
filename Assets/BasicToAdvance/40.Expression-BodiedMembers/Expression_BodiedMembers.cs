using UnityEngine;

namespace Expression_BodiedMembers
{
    public class Expression_BodiedMembers : MonoBehaviour
    {
        private void Start()
        {
            
        }

        public class Player
        {
            private string playerName;
            public string PlayerName
            {
                get => playerName;
                set => playerName = value;
            }

            public Player(string playerName) => this.playerName = playerName;

            // Expression bodied members : reduct the code line cleaned
            // and easy to read
            // only work in single instruction
            public string GetPlayerName() => playerName;
            public void SetPlayerName(string playerName) => this.playerName = playerName;
        }
    }
}