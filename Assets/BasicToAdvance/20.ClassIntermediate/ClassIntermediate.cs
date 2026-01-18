using System;
using UnityEngine;

namespace ClassIntermediate
{
    public class Program : MonoBehaviour
    {
        /*void Start()
        {
            //Unit unit = new Unit();
        }*/

        private void Update()
        {
            MyFunction();

            // Force the garbage collector to stop the object that use havy memory to prevent memery leak
            GC.Collect();
        }

        private void MyFunction()
        {
            Player player = new Player("P1");
            player.Move();
        }
    }

    // Inheritance : The class that derived a attribuite from base class
    // Base class
    public abstract class Unit
    {
        // Private : Can use only in this class
        private float speed;

        // Protected : Can use in this and derived of this class
        protected int health;

        /*public void Move()
        {
            Debug.Log("Move");
        }*/

        // Abstraction : The abstract key word to mark this func or method can be use in difference case to do how this method
        public abstract void Move();
    }

    // Derived class
    public class Player : Unit
    {
        private string playerName;

        // Constructor : Use to initialize value of this class on concrete class (on use Class = new Class();)
        public Player(string playerName)
        {
            //Move();
            this.playerName = playerName;
            health = 100;
        }

        // Desctructor : This will run the code when it was destroyed
        ~Player()
        {
            Debug.Log("Player Desctructor");
        }

        // Polymorphism : Override the abstraction method or other method that can impletement in multiple difference case
        public override void Move()
        {
            Debug.Log("Player Move");
        }
    }

    // Sealed : Mark the class to can't derived to the other class
    public sealed class Enemy : Unit
    {
        public override void Move()
        {
            Debug.Log("Enemy Move");
        }
    }
    //public class EnemyMelee : Enemy { }
    //public class EnemyMeleeBoss : EnemyMelee { }
}