using Interfaces;
using UnityEngine;

namespace CompairingVariousTypes
{
    public class Compairing : MonoBehaviour
    {
        private void Start()
        {
            IAttackable attackable = new Enemy();

            // is : check is the target is class?
            if (attackable is Player)
            {
                Debug.Log("Is Player");

                // attackable can't use method of Player class
                //attackable.Hello();

                // as : convert attackable to Player type
                // to use the method of Player class

                Player player = attackable as Player;

                // Or use Castable (targetType) to convert
                //Player player = (Player)attackable;

                player.SayHello();
            }
            else
            {
                Debug.Log("Is not a Player");
            }

            // typeOf : check is the target is type of class?
            // (Same of is)
            if (attackable.GetType() == typeof(Player))
            {
                Debug.Log("Is Player");
            }

            Player player2 = new Player();
            Enemy enemy = new Enemy();

            // When run this show an error
            //Player playerTest = (Player)attackable;

            // But this it prevent of error
            Player playerTest = attackable as Player;

            int a = 10;
            // Can't use as with int and float
            //float f = a as float;
            float f = (float)a;

            // keep value inside of object call "Boxing"
            // object : can keep any type of value in it
            object obj = a;
        }
    }

    public class Player : IAttackable, IMovable, IInventory
    {
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