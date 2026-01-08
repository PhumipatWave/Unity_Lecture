using UnityEngine;

namespace Inheritance
{
    public class Bird : Sky
    {
        private void Start()
        {
            Initial("BirdA");
            Move();
        }
    }
}