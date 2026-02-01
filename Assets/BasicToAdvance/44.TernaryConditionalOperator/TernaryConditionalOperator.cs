using UnityEngine;

namespace TernaryConditionalOperator
{
    // Ternary Conditional Operator : simple way to do if-else statements
    public class TernaryConditionalOperator : MonoBehaviour
    {
        private void Start()
        {
            Player player = new Player();
            player.health = 100;
            Debug.Log(player.GetPlayerStateString());
        }

        private class Player
        {
            public int health;

            public string GetPlayerStateString()
            {
                // Condition ? true : false;
                return health > 0 ? "ALIVE" : "DEAD";

                // if want to call a method
                int i = health > 0 ? HandlePlayerLogic() : DoNothing();

                /*if (health > 0)
                {
                    return "Alive";
                }
                else
                {
                    return "Dead";
                }*/
            }

            private int HandlePlayerLogic()
            {
                return 0;
            }

            private int DoNothing()
            {
                return 0;
            }
        }
    }
}