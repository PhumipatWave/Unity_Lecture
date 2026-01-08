using UnityEngine;

namespace MVP
{
    // Use for instantiate the MVP
    public class PlayerHealthInstaller : MonoBehaviour
    {
        [SerializeField] private HealthView view;
        private HealthPresenter presenter;

        private void Start()
        {
            var model = new HealthModel(100);
            presenter = new HealthPresenter(model, view);

            Debug.Log("Take Damage: Space, Heal: H");
        }

        private void OnDestroy()
        {
            presenter?.Dispose();
        }
    }
}