using UnityEngine;
using UnityEngine.UI;

namespace MVVM
{
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private Image healthBar;

        private HealthViewModel viewModel;

        private void Start()
        {
            var model = new HealthModel(100);
            viewModel = new HealthViewModel(model);

            viewModel.OnHealthChange += UpdateHealth;
            viewModel.Bind();

            Debug.Log("Take Damage: Space, Heal: H");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                viewModel.Damage(25);
            }

            if (Input.GetKeyDown(KeyCode.H))
            {
                viewModel.Heal(10);
            }
        }

        public void UpdateHealth(float health)
        {
            healthBar.fillAmount = health;
            Debug.Log($"Health = {health}");
        }
    }
}