using UnityEngine;

namespace Interfaces
{
    public class NPC : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log($"Talk to {name}");
        }
    }
}