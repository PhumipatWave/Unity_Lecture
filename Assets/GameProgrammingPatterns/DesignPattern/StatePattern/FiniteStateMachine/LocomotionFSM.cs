using UnityEngine;

public class LocomotionFSM : MonoBehaviour
{
    enum State
    {
        Idle,
        Walk,
        Jump
    }

    State currentState = State.Idle;

    private void Start()
    {
        Debug.Log($"Control\nWalk : W, Jump : Space, Fall : F");
    }

    private void Update()
    {
        switch (currentState)
        {
            case State.Idle:

                if (Input.GetKeyDown(KeyCode.W))
                {
                    currentState = State.Walk;
                }
                else if (Input.GetKeyDown(KeyCode.Space))
                {
                    currentState = State.Jump;
                }

                DebugMessage();
                break;

            case State.Walk:

                if (Input.GetKeyDown(KeyCode.S))
                {
                    currentState = State.Idle;
                }
                else if (Input.GetKeyDown(KeyCode.Space))
                {
                    currentState = State.Jump;
                }

                DebugMessage();
                break;

            case State.Jump:

                if (Input.GetKeyDown(KeyCode.F))
                {
                    currentState = State.Idle;
                }

                DebugMessage();
                break;
        }
    }

    public void DebugMessage()
    {
        Debug.Log($"Current State : {currentState}");
    }
}
