using Strategy;
using UnityEngine;

namespace Decorator
{
    public class PlayerAbility : MonoBehaviour
    {
        [SerializeField] private AbillityRunner abillityRunner;

        private void Awake()
        {
            abillityRunner = GetComponent<AbillityRunner>();
            abillityRunner.SetAbility(new DecoratorBehavior(new NormalAbility()));
            abillityRunner.UseAbility();
        }
    }
}