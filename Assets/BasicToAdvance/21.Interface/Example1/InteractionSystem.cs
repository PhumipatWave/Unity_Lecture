using UnityEngine;

namespace Interfaces
{
    public class InteractionSystem : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mouseWorldPos.z = 0f;

                Collider2D hit = Physics2D.OverlapPoint(mouseWorldPos);
                if (hit != null)
                {
                    if (hit.TryGetComponent(out IInteractable interactable)) interactable.Interact();
                }
            }
        }
    }
}