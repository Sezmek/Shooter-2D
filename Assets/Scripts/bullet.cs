using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 20f;
    [SerializeField] int attack = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        Destroy(gameObject, 2f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Hp hp = collision.gameObject.GetComponent<Hp>();
        if (hp != null )
        {
            hp.TakeDamage(attack, transform.position);
        }
        Destroy(gameObject);
    }
}
