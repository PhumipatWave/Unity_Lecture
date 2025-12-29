public interface ILocomotionContext
{
    void StateTransitionTo(ILocomotionState newState);
}

public interface ILocomotionState
{
    void Enter(ILocomotionContext context);
    void Update(ILocomotionContext context);
    void Exit(ILocomotionContext context);
}