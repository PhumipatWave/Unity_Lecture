using UnityEngine;

namespace Inheritance
{
    public class Land : Animal
    {
        protected void Jump()
        {
            Debug.Log($"{animalName} Jump");
        }
    }
}