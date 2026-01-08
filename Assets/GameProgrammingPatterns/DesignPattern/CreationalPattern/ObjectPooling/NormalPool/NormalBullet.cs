using UnityEngine;

public class NormalBullet : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.linearVelocity = Vector2.right * speed;
    }

    private void OnBecameInvisible()
    {
        NormalPool.instance.ReturnPrefab(this.gameObject, NormalPool.instance.PrefabPool);
    }
}
