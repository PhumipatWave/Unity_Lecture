using UnityEngine;

namespace TypeOf
{
    public class TypeOf : MonoBehaviour
    {
        private void Start()
        {
            Player player = new Player();
            player.GetType();

            // typeof
            GetComponent(typeof(Player));
            // Generic type
            //GetComponent<Player>();
        }

        public class Player { }
    }
}