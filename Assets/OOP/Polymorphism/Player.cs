using UnityEngine;

namespace Polymorphism
{
    public class Player : Character
    {
        [SerializeField] private Enemy enemy;

        protected void Start()
        {
            Attack(enemy);
        }

        protected override void Initialize()
        {
            health = 100;
            Debug.Log($"{this.name} health : {health}");
        }

        protected override void Attack<T>(T target)
        {
            Debug.Log($"{this.name} Attack {target.name} : {target.health}");
            target.TakeDamage(25);
            Debug.Log($"{target.name} health : {target.health}");
        }
    }
}