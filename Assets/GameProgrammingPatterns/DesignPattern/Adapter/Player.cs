using UnityEngine;

namespace Adapter
{
    public class Player : MonoBehaviour
    {
        private IMoveable moveable;

        void Start()
        {
            moveable = new MoveAdapter(new OldMoveSystem());
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                moveable.Move("New Move");
            }
        }
    }
}