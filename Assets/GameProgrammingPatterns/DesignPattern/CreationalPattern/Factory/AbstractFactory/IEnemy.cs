using UnityEngine;

namespace AbstractFactory
{
    public interface IEnemy
    {
        public void Attack();
    }

    public class Knight : IEnemy
    {
        public void Attack() => Debug.Log("Sword attack");
    }

    public class TankKnight : IEnemy
    {
        public void Attack() => Debug.Log("Shield attack");
    }

    public class Archer : IEnemy
    {
        public void Attack() => Debug.Log("Archer attack");
    }

    public class HeavyArcher : IEnemy
    {
        public void Attack() => Debug.Log("LeaderArcher attack");
    }
}