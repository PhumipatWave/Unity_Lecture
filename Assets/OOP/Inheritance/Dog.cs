using UnityEngine;

namespace Inheritance
{
    public class Dog : Land
    {
        private void Start()
        {
            Initial("DogC");
            Move();
        }
    }
}