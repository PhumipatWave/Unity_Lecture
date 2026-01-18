using UnityEngine;

namespace Polymorphism
{
    public class Enemy : Character
    {
        [SerializeField] private Player player;

        protected void Start()
        {
            Attack(player);
        }

        protected override void Initialize()
        {
            health = 80;
            Debug.Log($"{this.name} health : {health}");

            Attack(player);
        }

        protected override void Attack<T>(T target)
        {
            Debug.Log($"{this.name} Attack {target.name} : {target.health}");
            target.TakeDamage(10);
            Debug.Log($"{target.name} health : {target.health}");
        }
    }
}