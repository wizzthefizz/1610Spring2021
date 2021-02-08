using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public Rigidbody2D BallRigidbody2D;

    public float speed = 3f;
    public float jumpForce = 20f;

    private Vector2 direction;
    private Vector2 yDirection;

    private int score;
    
    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        if(!Input.GetButtonDown("Jump")) return;
        yDirection.y = jumpForce;
    }

    private void FixedUpdate()
    {
        var newDirection = direction * (speed * Time.deltaTime);
        BallRigidbody2D.AddForce(newDirection, ForceMode2D.Force);
        BallRigidbody2D.AddForce(yDirection, ForceMode2D.Force);
    }
}
