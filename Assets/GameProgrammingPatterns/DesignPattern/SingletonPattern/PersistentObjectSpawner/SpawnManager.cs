using UnityEngine;

namespace PersistenObject
{
    public class SpawnManager : MonoBehaviour
    {
        public static SpawnManager instance { get; private set; }

        void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(gameObject);
                return;
            }

            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public void RandomSpawn()
        {
            Debug.Log("Random Spawn");
        }
    }
}