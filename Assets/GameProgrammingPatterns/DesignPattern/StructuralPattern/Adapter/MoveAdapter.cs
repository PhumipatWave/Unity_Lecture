using UnityEngine;

namespace Adapter
{
    // Adapter : Wrap the existing class (Adaptee) and translates calls
    public class MoveAdapter : IMoveable
    {
        private OldMoveSystem oldMove;

        public MoveAdapter(OldMoveSystem oldMove)
        {
            this.oldMove = oldMove;
        }

        public void Move(string moveAction)
        {
            Debug.Log(moveAction);
        }
    }
}