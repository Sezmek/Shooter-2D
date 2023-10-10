using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_MoveMent : MonoBehaviour
{
    float directionX;
    float speedX = 10f;
    Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        directionX = Input.GetAxisRaw("Horizontal"); 
    }

    private void FixedUpdate()
    {
       rb.velocity = new Vector2 (directionX* speedX, rb.velocity.y);
    }
}
