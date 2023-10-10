using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Vector2 jumpForce = new Vector2(0f, 3000f);
    public bool isJumping = false;
    Rigidbody2D rb;
    int JumpNumber = 0;
    int MaxJumpNumber = 1;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space)) 
        {
            isJumping = true;
            JumpNumber++;
        }
    }

    private void FixedUpdate()
    {
        Jump();
    }

    private void Jump()
    {
        if (isJumping && JumpNumber <= MaxJumpNumber)
        {
            rb.AddForce(jumpForce, ForceMode2D.Impulse);
        }
        if (Mathf.Abs(rb.velocity.y) < 0.001f)
        {
            JumpNumber=0;
        }
        isJumping=false;
    }
}
