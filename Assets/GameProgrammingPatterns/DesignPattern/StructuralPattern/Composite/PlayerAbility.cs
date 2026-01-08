using Decorator;
using UnityEngine;

namespace Composite
{
    public class PlayerAbility : MonoBehaviour
    {
        [SerializeField] private AbillityRunner abillityRunner;

        private void Awake()
        {
            abillityRunner = GetComponent<AbillityRunner>();
            abillityRunner.SetAbility(new SequenceComposite(
                new IAbility[]
                {
                    new NormalAbility(),
                    new RageAbility(),
                    new FireballAbility(),
                    new DecoratorBehavior(new HealAbility())
                }));
            abillityRunner.UseAbility();
        }
    }
}