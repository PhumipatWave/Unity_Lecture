using UnityEngine;

namespace Command
{
    public class MoveCommand : ICommand
    {
        private PlayerMover playerMover;
        private Vector2 movement;

        public MoveCommand(PlayerMover playerMover, Vector2 movement)
        {
            this.playerMover = playerMover;
            this.movement = movement;
        }

        public void Execute()
        {
            playerMover.Move(movement);
        }

        public void Undo()
        {
            playerMover.Move(-movement);
        }
    }
}