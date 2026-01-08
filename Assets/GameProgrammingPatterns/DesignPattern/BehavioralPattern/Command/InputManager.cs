using UnityEngine;

namespace Command
{
    public class InputManager : MonoBehaviour
    {
        private CommandInvoker commandInvoker = new CommandInvoker();
        private PlayerMover playerMover;

        private void Awake()
        {
            playerMover = GetComponent<PlayerMover>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                RunPlayerCommand(Vector2.up);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                RunPlayerCommand(Vector2.left);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                RunPlayerCommand(Vector2.down);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                RunPlayerCommand(Vector2.right);
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                commandInvoker.UndoCommand();
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                commandInvoker.RedoCommand();
            }
        }

        public void RunPlayerCommand(Vector2 dir)
        {
            ICommand command = new MoveCommand(playerMover, dir);
            commandInvoker.ExecuteCommand(command);
        }
    }
}