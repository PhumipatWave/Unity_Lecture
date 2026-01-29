using UnityEngine;

namespace Interfaces
{
    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            // Polymophism
            /*IAttackable attackable = new Player();
            attackable.Damage();*/

            AttackObject(new Player());
            AttackObject(new Enemy());
        }

        private void AttackObject(IAttackable attackable)
        {
            attackable.Damage();
        }
    }
}