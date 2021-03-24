﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int creditValue = 3;
    public IntData numberCount;
    public Text CounterText;

    private void Start()
    {
        CounterText.text = numberCount.value.ToString();
    }

    void OnTriggerEnter2D()
    {
        numberCount.value += creditValue;
        CounterText.text = numberCount.value.ToString();
        gameObject.SetActive(false);
    }
}
