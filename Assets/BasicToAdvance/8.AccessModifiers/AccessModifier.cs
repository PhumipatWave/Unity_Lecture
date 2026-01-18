using UnityEngine;

namespace AccessModifiers
{
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Player player1 = new Player("Player 1");
            player1.SayHello();
            Player player2 = new Player("Player 2");
            player2.SayHello();

            player1.name = "New Player";
        }
    }

    public class Player
    {
        // Public : can call on other class
        // Private : can call only inside of this class, it default access modifier
        public string name = "Player";

        public Player(string name)
        {
            this.name = name;
            Debug.Log($"Creating player {name}");
        }

        public void SayHello()
        {
            Debug.Log($"Hello {name}");
        }
    }
}