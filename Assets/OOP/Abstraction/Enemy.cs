using UnityEngine;

namespace Abstraction
{
    public class Enemy : Character
    {
        public override void Initailize()
        {
            characterName = "Enemy";
        }

        protected override void Move()
        {
            Debug.Log($"{characterName} : Move");
        }
    }
}