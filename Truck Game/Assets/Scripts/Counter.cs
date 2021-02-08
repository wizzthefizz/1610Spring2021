using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int numberCount;
    public Text CounterText;
    
    
    void Update()
    {
        numberCount++;
        CounterText.text = numberCount.ToString();
    }
}
