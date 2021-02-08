using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int creditValue = 3;
    public int numberCount;
    public Text CounterText;
    
    
    void OnTriggerEnter2D()
    {
        numberCount += creditValue;
        CounterText.text = numberCount.ToString();
        gameObject.SetActive(false);
    }
}
