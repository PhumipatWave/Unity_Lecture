using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class NormalPool : MonoBehaviour
{
    public GameObject bulletPrefab;

    [SerializeField] private int poolSize = 10;
    private List<GameObject> prefabPool = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < poolSize; i++)
        {
            CreateNewPrefab(bulletPrefab, prefabPool);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPrefab(bulletPrefab, prefabPool);
        }
    }

    public void CreateNewPrefab(GameObject obj, List<GameObject> pool)
    {
        var prefab = Instantiate(obj, Vector2.zero, Quaternion.identity);
        prefab.SetActive(false);
        pool.Add(prefab);
    }

    public GameObject SpawnPrefab(GameObject obj, List<GameObject> pool)
    {
        if (pool.Count == 0)
        {
            CreateNewPrefab(bulletPrefab, prefabPool);
        }

        int random = Random.Range(0, pool.Count);
        var prefab = pool[random];
        pool.RemoveAt(random);
        prefab.transform.position = Vector2.zero;
        prefab.SetActive(true);
        return prefab;
    }

    public void ReturnPrefab(GameObject obj, List<GameObject> pool)
    {
        pool.Add(obj);
        obj.SetActive(false);
    }
}
