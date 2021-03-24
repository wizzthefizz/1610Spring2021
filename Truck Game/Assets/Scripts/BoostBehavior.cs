using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostBehavior : MonoBehaviour
{
    public bool hasKey;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (hasKey)
        {
            print("True");
        }
    }
}
