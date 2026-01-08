using UnityEngine;

namespace Inheritance
{
    public class Fish : UnderWater
    {
        private void Start()
        {
            Initial("FishD");
            Move();
        }
    }
}