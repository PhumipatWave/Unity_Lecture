using UnityEngine;

namespace Interfaces
{
    public interface IAttackable
    {
        // Interface can't has a field
        // but can has a property
        //public int Health { get; set; }

        public void Damage()
        {
            Debug.Log("Damage");
        }
    }

    public interface IMovable { }
    public interface IInventory { }
}