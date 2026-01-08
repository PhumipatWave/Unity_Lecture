using UnityEngine;

namespace Command
{
    public class PlayerMover : MonoBehaviour
    {
        public float moveDistance = 1f;

        public void Move(Vector2 dir)
        {
            transform.position += (Vector3)(dir * moveDistance);
        }
    }
}