using UnityEngine;

namespace SingletonPattern
{
    public class SingltonPattern : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log(GameManager.Instance);
        }

        public class GameManager : MonoBehaviour
        {
            public static GameManager Instance {  get; private set; }

            private void Awake()
            {
                if (Instance != null)
                {
                    Debug.LogError("Instance already exits");
                    Destroy(gameObject);
                    return;
                }
                Instance = this;
            }
        }
    }
}