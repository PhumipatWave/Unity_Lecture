using UnityEngine;

namespace Encapsulation
{
    public class Player : MonoBehaviour
    {
        private int health;
        public int Health 
        {
            get { return health; } 
            private set { health = Mathf.Clamp(value, 0, maxHealth); }

            /*private set
            {
                if (health > 0 || health < maxHealth) health = value;
            }*/

            //get => return health;
            //private set => health = Mathf.Clamp(value, 0, maxHealth);
        }

        private int maxHealth = 100;

        public void Instaintiate(int health)
        {
            Health = health;
        }
    }
}