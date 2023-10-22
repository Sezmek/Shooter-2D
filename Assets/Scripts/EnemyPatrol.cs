using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody2D rb;
    SpriteRenderer rb2D;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb2D = GetComponent<SpriteRenderer>();
    }
    private void Start()
    {
        rb.velocity = Vector2.left * speed;

    }
    public void SetVelocity()
    {
        rb.velocity = Vector2.zero;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Point"))
        {
            rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -1f, 1f) * -1, 0f) * speed;
            transform.localScale = new Vector3(Mathf.Clamp(rb.velocity.x, -1f, 1f) * -1, 1f, 1f);
        }

    }
}
