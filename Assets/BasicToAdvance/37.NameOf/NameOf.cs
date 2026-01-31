using UnityEngine;

namespace NameOf
{
    public class NameOf : MonoBehaviour
    {
        private void Start()
        {
            string playerClassName = "Player";


            // nameof : execute on compile time. good performant
            playerClassName = nameof(Unit);
            Debug.Log(nameof(Unit));
            Debug.Log(nameof(Unit.speed));
            Debug.Log(nameof(Unit.IsGrounded));

            Unit unit = new Unit();
            unit.SetSpeed(0);

            // This will execute on run time
            Debug.Log(unit.GetType().Name);
        }

        public class Unit
        {
            public int speed;

            public bool IsGrounded()
            {
                return true;
            }

            public void SetSpeed(int speedToSet)
            {
                if (speedToSet == 0)
                {
                    Debug.Log($"Error : {nameof(speedToSet)} must not be 0");
                }
                this.speed = speedToSet;
            }
        }
    }
}