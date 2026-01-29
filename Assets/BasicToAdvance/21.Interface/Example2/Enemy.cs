using UnityEngine;

namespace Interfaces
{
    public class Enemy : IAttackable, IMovable
    {
        public void Damage()
        {
            Debug.Log("Enemy Damage");
        }
    }
}