using UnityEngine;

namespace Classes
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Player player1 = new Player("Player 1");
            player1.SayHello();

            Player player2 = new Player("Player 2");
            player2.SayHello();
        }
    }

    public class Player
    {
        string name = "Player";

        public Player(string name)
        {
            this.name = name;
            Debug.Log($"Creating player {this.name}");
        }

        public void SayHello()
        {
            Debug.Log($"Hello {name}");
        }
    }
}