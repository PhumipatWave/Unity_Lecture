using UnityEngine;

namespace Interfaces
{
    public class TextSign : MonoBehaviour, IInteractable
    {
        public void Interact()
        {
            Debug.Log($"Read the {name}");
        }
    }
}