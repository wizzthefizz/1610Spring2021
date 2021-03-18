using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Trigger2DBehavior : MonoBehaviour
{
    public UnityEvent triggerEvent;
    private void OnTriggerEnter2D(Collider2D other)
    {   
        triggerEvent.Invoke();
    }
}
