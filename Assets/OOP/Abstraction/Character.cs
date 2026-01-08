using UnityEngine;

namespace Abstraction
{
    public abstract class Character : MonoBehaviour
    {
        public string characterName;
        private float speed;

        private void Start()
        {
            Initailize();
            Move();
        }

        public abstract void Initailize();
        protected abstract void Move();
    }
}