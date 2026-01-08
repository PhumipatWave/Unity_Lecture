using UnityEngine;
using UnityEngine.SceneManagement;

namespace PersistenObject
{

    // Save for multiple of Sigleton in 1 prefab

    public class PersistentObjectSpwaner : MonoBehaviour
    {
        [SerializeField] GameObject persistentObjectPrefab = null;

        static bool hasSpawned = false;

        void Awake()
        {
            if (hasSpawned) return;

            GameObject persistentObject = Instantiate(persistentObjectPrefab);
            DontDestroyOnLoad(persistentObject);

            hasSpawned = true;
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }
}