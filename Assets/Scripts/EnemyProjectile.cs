using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] private float speed = 5f;

    private float direction;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetDirection(float _direction)
    {
        direction = _direction;

        gameObject.SetActive(true);

        rb.linearVelocity = new Vector2(direction * speed, 0);
    }

    private void Update()
    {
        rb.linearVelocity = new Vector2(direction * speed, 0);
    }

    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}