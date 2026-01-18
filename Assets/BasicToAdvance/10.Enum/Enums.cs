using System;
using UnityEngine;

namespace Enums
{
    public class Enums : MonoBehaviour
    {
        private void Start()
        {
            // Enum store the value with int
            PlayerAction playerAction = PlayerAction.Idle;
            Debug.Log((int)playerAction);
            Debug.Log((PlayerAction)2);

            State gameState = State.Level1;
            gameState++;
            string gameStateString = gameState.ToString();
            Debug.Log(Enum.Parse<State>(gameStateString));

            foreach (State state in Enum.GetValues(typeof(State)))
            {
                Debug.Log(state);
            }
        }

        #region EnumExample1
        private bool isRunning;
        private bool isJumping;

        private enum PlayerAction
        {
            Idle,
            Run,
            Jump
        }

        private PlayerAction GetNextPlayerAction()
        {
            //PlayerAction action = PlayerAction.Idle;

            if (isRunning)
            {
                return PlayerAction.Run;
            }
            else if (isJumping)
            {
                return PlayerAction.Jump;
            }
            else
            {
                return PlayerAction.Idle;
            }
        }
        #endregion

        #region EnumExample2
        private enum State
        {
            GameMenu,
            Level1,
            Level2
        }

        private State state;

        private void HandleState()
        {
            switch (state)
            {
                case State.GameMenu:
                    // Logic
                    break;

                case State.Level1:

                    break; 

                case State.Level2:

                    break;
            }
        }
        #endregion
    }
}