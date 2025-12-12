using UnityEngine;

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
}
