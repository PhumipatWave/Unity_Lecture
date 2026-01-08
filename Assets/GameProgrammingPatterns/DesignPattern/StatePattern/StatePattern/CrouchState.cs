using UnityEngine;

namespace State
{
    public class CrouchState : ILocomotionState
    {
        public void Enter(ILocomotionContext context)
        {
            // Set logic on Enter
            Debug.Log("Enter Crouch State");
            Debug.Log($"Control\nGround : C Jump : Space");
        }

        public void Update(ILocomotionContext context)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                context.StateTransitionTo(new GroundState());
            }
            else if (Input.GetKeyDown(KeyCode.Space))
            {
                context.StateTransitionTo(new AirState());
            }
        }

        public void Exit(ILocomotionContext context)
        {
            // Set logic on Exit
            Debug.Log("Exit Crouch State");
        }
    }
}