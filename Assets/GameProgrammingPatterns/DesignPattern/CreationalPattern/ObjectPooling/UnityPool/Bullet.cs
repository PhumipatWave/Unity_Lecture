using UnityEngine;
using UnityEngine.Pool;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;

    private IObjectPool<Bullet> bulletPool;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.linearVelocity = Vector2.right * speed;
    }

    public void SetPool(IObjectPool<Bullet> pool)
    {
        bulletPool = pool;
    }

    private void OnBecameInvisible()
    {
        bulletPool.Release(this);
    }
}
