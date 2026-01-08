using UnityEngine;

namespace Strategy
{
    // Strategy Pattern is behavioral design pattern
    // "Choose how to do something"
    public class AbillityRunner : MonoBehaviour
    {
        // Define family of Algorithms, encapsulate all of Interface
        // And swap at runtime without change object

        private IAbility currentAbility;

        public void UseAbility()
        {
            currentAbility.Use();
        }

        // Encapsulate the IAbility
        public void SetAbility(IAbility targetAbility)
        {
            currentAbility = targetAbility;
            Debug.Log($"Change ability to {currentAbility}");
        }
    }
}