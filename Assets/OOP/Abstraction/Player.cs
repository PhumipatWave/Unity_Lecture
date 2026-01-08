using UnityEngine;

namespace Abstraction
{
    public class Player : Character
    {
        public override void Initailize()
        {
            characterName = "Player";
        }

        protected override void Move()
        {
            Debug.Log($"{characterName} : Move");
        }
    }
}