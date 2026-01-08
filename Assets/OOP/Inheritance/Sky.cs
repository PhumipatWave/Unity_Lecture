using UnityEngine;

namespace Inheritance
{
    public class Sky : Animal
    {
        public override void Move()
        {
            Debug.Log($"{animalName} Fly");
        }
    }
}