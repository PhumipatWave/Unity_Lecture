using UnityEngine;

namespace Decorator
{
    public class AbillityRunner : MonoBehaviour
    {
        private IAbility currentAbility;

        public void UseAbility()
        {
            currentAbility.Use();
        }

        public void SetAbility(IAbility targetAbility)
        {
            currentAbility = targetAbility;
            Debug.Log($"Change ability to {currentAbility}");
        }
    }

}