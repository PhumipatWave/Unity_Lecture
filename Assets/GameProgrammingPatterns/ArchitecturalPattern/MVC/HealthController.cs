using UnityEngine;

namespace MVC
{
    // Control : Handle input and connect Model <=> View
    public class HealthController : MonoBehaviour
    {
        [SerializeField] private HealthView view;
        private HealthModel model;

        private void Start()
        {
            model = new HealthModel(100);
            model.OnHealthChange += view.UpdateHealth;
            view.UpdateHealth(model.CurrentHealth, model.MaxHealth);

            Debug.Log("Take Damage: Space, Heal: H");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                model.TakeDamage(25);
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                model.Heal(10);
            }
        }
    }
}