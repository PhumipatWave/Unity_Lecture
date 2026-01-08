using UnityEngine;

namespace AbstractFactory
{
    public class UnitCreator : MonoBehaviour
    {
        // Abstract Factory : Create families of object
        void Start()
        {
            IFactory factory = new BowUnitFactory();

            IEnemy enemy = factory.CreateEnemy();
            enemy.Attack();

            IWeapon weapon = factory.CreateWeapon();
            weapon.Use();
        }
    }
}