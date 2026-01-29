using UnityEngine;

namespace SwitchTypeMatching
{
    public class SwitchTypeMatching : MonoBehaviour
    {
        private void Start()
        {
            IAttackable attackable = new Player()
            {
                health = 0
            };

            switch (attackable)
            {
                // Switch type matching :
                // Can use class and assign to variable to use it
                // And can use when to defind condition of the case
                case Player player when player.health > 50 :
                    player.SayHello();
                    break;

                case Player player when player.health < 50:
                    Debug.Log($"Low Health {player.health}");
                    break;

                case Enemy enemy :
                    enemy.Damage();
                    break;

                default:
                    break;
            }
        }
    }

    public class Player : IAttackable, IMovable, IInventory
    {
        public int health;

        public void Damage()
        {
            Debug.Log("Player Damage");
        }

        public void SayHello()
        {
            Debug.Log("Hello");
        }
    }

    public class Enemy : IAttackable
    {
        public void Damage()
        {
            Debug.Log("Enemy Damage");
        }
    }

    public interface IAttackable
    {
        public void Damage();
    }
    public interface IMovable { }
    public interface IInventory { }
}