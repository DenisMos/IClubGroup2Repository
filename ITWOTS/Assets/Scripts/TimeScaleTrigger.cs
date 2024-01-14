using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TimeScaleTrigger : MonoBehaviour
{
    private float fixedDeltaTime;
    public float lowspeed = 0.3f;
    public float normalspeed = 1f;

    void Awake()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = lowspeed;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Time.timeScale = normalspeed;
        }
    }
}
