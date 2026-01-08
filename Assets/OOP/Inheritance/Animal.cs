using UnityEngine;

namespace Inheritance
{
    public abstract class Animal : MonoBehaviour
    {
        public string animalName;

        public void Initial(string name)
        {
            animalName = name;
        }

        public virtual void Move()
        {
            Debug.Log($"{animalName} Default Move");
        }
    }
}