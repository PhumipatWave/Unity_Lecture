using UnityEngine;

namespace State
{
    public class AirState : ILocomotionState
    {
        public void Enter(ILocomotionContext context)
        {
            // Set logic on Enter
            Debug.Log("Enter Air State");
            Debug.Log($"Control\nFall : F");
        }

        public void Update(ILocomotionContext context)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                context.StateTransitionTo(new GroundState());
            }
        }

        public void Exit(ILocomotionContext context)
        {
            // Set logic on Exit
            Debug.Log("Exit Air State");
        }
    }
}