using System.Collections.Generic;
using UnityEngine;

public class NormalPool : MonoBehaviour
{
    #region Singleton
    public static NormalPool instance {  get; private set; }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    #endregion

    public GameObject bulletPrefab;

    [SerializeField] private int poolSize = 10;

    public List<GameObject> PrefabPool 
    {
        get { return prefabPool; }
        set { prefabPool = value; }
    }
    private List<GameObject> prefabPool = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            CreateNewPrefab(bulletPrefab, PrefabPool);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPrefab(bulletPrefab, PrefabPool);
        }
    }

    public void CreateNewPrefab(GameObject obj, List<GameObject> pool)
    {
        var prefab = Instantiate(obj, Vector2.zero, Quaternion.identity);
        prefab.SetActive(false);
        pool.Add(prefab);

        Debug.Log($"Add new prefab {obj} to {pool}");
    }

    public GameObject SpawnPrefab(GameObject obj, List<GameObject> pool)
    {
        if (pool.Count == 0)
        {
            CreateNewPrefab(bulletPrefab, PrefabPool);
        }

        int random = Random.Range(0, pool.Count);
        var prefab = pool[random];
        pool.RemoveAt(random);
        prefab.transform.position = Vector2.zero;
        prefab.SetActive(true);

        Debug.Log($"Remove prefab {obj} from {pool}");

        return prefab;
    }

    public void ReturnPrefab(GameObject obj, List<GameObject> pool)
    {
        pool.Add(obj);
        obj.SetActive(false);

        Debug.Log($"Return prefab : {obj} to {pool}");
    }
}
