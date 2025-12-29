using UnityEngine;

public class GroundState : ILocomotionState
{
    public void Enter(ILocomotionContext context)
    {
        // Set logic on Enter
        Debug.Log("Enter Ground State");
        Debug.Log($"Control\nCrouch : C, Jump : Space");
    }

    public void Update(ILocomotionContext context)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            context.StateTransitionTo(new AirState());
        }
        else if (Input.GetKeyDown(KeyCode.C))
        {
            context.StateTransitionTo(new CrouchState());
        }
    }

    public void Exit(ILocomotionContext context)
    {
        // Set logic on Exit
        Debug.Log("Exit Ground State");
    }
}