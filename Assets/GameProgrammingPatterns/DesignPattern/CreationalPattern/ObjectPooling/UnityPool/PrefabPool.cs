using System;
using UnityEngine;
using UnityEngine.Pool;

public class PrefabPool : MonoBehaviour
{
    [SerializeField] private Bullet bulletPrefab;
    private IObjectPool<Bullet> bulletPool;

    [SerializeField] int maxPoolSize = 10;

    private void Awake()
    {
        bulletPool = new ObjectPool<Bullet>(CreateBullet, OnGet, OnRelease, OnDestroyed, maxSize: maxPoolSize);

        for (int i = 0; i < maxPoolSize; i++)
        {
            var obj = CreateBullet();
            bulletPool.Release(obj);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bulletPool.Get();
        }
    }

    private Bullet CreateBullet()
    {
        Bullet bullet = Instantiate(bulletPrefab);
        bullet.SetPool(bulletPool);
        return bullet;
    }

    private void OnGet(Bullet bullet)
    {
        bullet.gameObject.SetActive(true);
        bullet.transform.position = transform.position;
    }

    private void OnRelease(Bullet bullet)
    {
        bullet.gameObject.SetActive(false);
    }

    private void OnDestroyed(Bullet bullet)
    {
        Destroy(bullet.gameObject);
    }
}
