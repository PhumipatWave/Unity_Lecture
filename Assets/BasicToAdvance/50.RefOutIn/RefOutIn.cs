using UnityEngine;

namespace RefOutIn
{
    public enum State
    {
        Idle,
        Patrolling,
        Attacking
    }

    public class RefOutIn : MonoBehaviour
    {
        private void Start()
        {
            Unit unit = new Unit();

            State stat = State.Idle;
            string unitType = "Soldier";

            // out : if mark parameter as out, you don't need to initialize it before passing to method
            // ref : you must initialize it before passing to method
            // _ : discard variable, ignore output value
            unit.GetUnitState(ref stat, out _, out string name, unitType);
            Debug.Log($"{stat}, {name}");
        }

        public class Unit
        {
            // out : mark parameter to output value from method
            // ref : mark parameter to pass value by reference and modify it in method
            public void GetUnitState(ref State state, out int healthAmount, out string name, in string unitType)
            {
                // ref parameter can be not assigned in method
                state = State.Idle;

                // out parameters must be assigned before method ends
                healthAmount = 100;
                name = "Unit Test";

                // in : cannot be modified in method
                //unitType = "New Type"; 
            }

            public void Heal(ref int healthAmount, int healValue)
            {
                healthAmount += healValue;
            }
        }
    }
}