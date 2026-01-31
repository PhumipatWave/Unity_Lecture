using UnityEngine;

namespace StaticConstructor
{
    public class StaticConstructor : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log(Player.i);
            Player.TestFunction();

            Player player = new Player();
        }

        public class Player
        {
            // Static Constructor : run automatic. can't has parameter
            // Run before normal constructor and normal static function
            static Player()
            {
                Debug.Log("Player Static Constructor");
                i = 50;
            }

            public static int i;

            public static void TestFunction()
            {
                Debug.Log("Test Function");
            }

            public Player()
            {
                Debug.Log("Player Constructor");
            }
        }
    }
}