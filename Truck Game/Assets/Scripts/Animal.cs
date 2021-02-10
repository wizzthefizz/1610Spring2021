using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
   public Color animalColor = Color.red;
   public float speed = 1f;
   public string animalName = "Bob";
   public int health = 10;

   private void Start()
   {
      Debug.Log("Hello world!");
   }
}
