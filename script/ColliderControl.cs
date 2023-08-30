using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColliderControl : MonoBehaviour
{
    public UnityEvent myEventFanOn, myEventFanOff;
    void Start()
    {
        
    }
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            myEventFanOn.Invoke();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            myEventFanOff.Invoke();
        }
    }
}
