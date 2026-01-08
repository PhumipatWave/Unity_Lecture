using UnityEngine;

namespace Inheritance
{
    public class Cat : Land
    {
        private void Start()
        {
            Initial("CatB");
            Move();
        }
    }
}