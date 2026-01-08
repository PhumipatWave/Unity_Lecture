using UnityEngine;

namespace Inheritance
{
    public class UnderWater : Animal
    {
        public override void Move()
        {
            Debug.Log($"{animalName} Swim");
        }
    }
}