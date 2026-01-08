namespace State
{
    // Use to change to the new state
    public interface ILocomotionContext
    {
        void StateTransitionTo(ILocomotionState newState);
    }


    // Use to Define what function that use in this state
    // Like Enter state, Update in state, Exit state...
    public interface ILocomotionState
    {
        void Enter(ILocomotionContext context);
        void Update(ILocomotionContext context);
        void Exit(ILocomotionContext context);
    }
}