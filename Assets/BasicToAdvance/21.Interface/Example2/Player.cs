using UnityEngine;

namespace Interfaces
{
    // Interface can multiple of inheritance 
    public class Player : IAttackable, IMovable, IInventory
    {
        public void Damage()
        {
            Debug.Log("Player Damage");
        }
    }
}