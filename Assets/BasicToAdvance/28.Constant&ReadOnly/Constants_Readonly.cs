using UnityEngine;

namespace ConstantsAndReadonly
{
    public class Constants_Readonly : MonoBehaviour
    {
        // const : mark the variable to constant variable
        // can't change the value of it
        // const : use UPPERCASE and Snake_Case
        private const float MOVE_SPEED = 5f;

        // readonly : mark variable to call only before set the initailize value
        private readonly Player player = new Player(10);

        public class Player 
        {
            private readonly int maxHealth;

            public Player(int maxHealth)
            {
                // readonly : can use in contructor to initialize value
                // before lock the value and can't change it after this
                this.maxHealth = maxHealth;
            }
        }
    }
}