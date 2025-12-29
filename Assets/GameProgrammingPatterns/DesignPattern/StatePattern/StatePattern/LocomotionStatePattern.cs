using UnityEngine;

public class LocomotionStatePattern : MonoBehaviour, ILocomotionContext
{
    ILocomotionState currentState = new GroundState();

    public void Enter() => currentState.Enter(this);
    public void Update() => currentState.Update(this);
    public void Exit() => currentState.Exit(this);

    private void Start()
    {
        currentState.Enter(this);
    }

    void ILocomotionContext.StateTransitionTo(ILocomotionState newState)
    {
        currentState.Exit(this);
        currentState = newState;
        currentState.Enter(this);

        Debug.Log($"Transition to : {currentState}");
    }
}