using UnityEngine;

namespace Encapsulation
{
    public class DebugMessage : MonoBehaviour
    {
        [SerializeField] private Player player;

        private void Start()
        {
            player.Instaintiate(200);
            Debug.Log($"Player health : {player.Health}");
        }
    }
}