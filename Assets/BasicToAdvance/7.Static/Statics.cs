using UnityEngine;

namespace Statics
{
    #region StaticExample1
    public class Main : MonoBehaviour
    {
        private void Start()
        {
            Player.SayHello();
            new Player("Player 1");
            Player.SayHello();
            new Player("Player 2");
            Player.SayHello();
        }
    }

    public class Player
    {
        static string name = "Player";

        public Player(string name)
        {
            Player.name = name;
            Debug.Log($"Creating player {name}");
        }

        public static void SayHello()
        {
            Debug.Log($"Hello {Player.name}");
        }
    }
    #endregion

    #region StaticExample2
    /*public class Main : MonoBehaviour
    {
        private void Start()
        {
            // If create new object in static and change value of variable
            // The variable inside this it set to last object that set it
            // The variable is use base on all object that call this static
            Player player = new Player("Player 1");
            Player player2 = new Player("Player 2");
            player.SayHello();
        }
    }

    public class Player
    {
        static string name = "Player";

        public Player(string name)
        {
            Player.name = name;
            Debug.Log($"Creating player {name}");
        }

        public void SayHello()
        {
            Debug.Log($"Hello {name}");
        }
    }*/
    #endregion

    #region StaticExample3
    /*public class Main : MonoBehaviour
    {
        private void Start()
        {
            Player.SayHello();
        }
    }

    // Static can't use none static & Constructure inside
    public static class Player
    {
        static string name = "Player";

        public static void SayHello()
        {
            Debug.Log($"Hello {name}");
        }
    }*/
    #endregion
}