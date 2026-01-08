using UnityEngine;
using UnityEngine.UI;

namespace MVC
{
    // View : Update UI only
    public class HealthView : MonoBehaviour
    {
        [SerializeField] private Image healthBar;

        public void UpdateHealth(int current, int max)
        {
            healthBar.fillAmount = (float)current / max;
            Debug.Log($"Health = {current}");
        }
    }
}