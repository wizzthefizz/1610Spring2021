﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour
{
    public float speed = 3f;
    public float jumpForce = 3f;
    public Rigidbody2D rigidbodyObj;
    
    private Vector2 direction;

    private void Update()
    {
        direction.x = Input.GetAxis("Horizontal") * speed;
        rigidbodyObj.AddForce(direction, ForceMode2D.Force);

        if (Input.GetButtonDown("Jump"))
        {
            direction.y = jumpForce;
            rigidbodyObj.AddForce(direction, ForceMode2D.Impulse);
        }
    }
}
