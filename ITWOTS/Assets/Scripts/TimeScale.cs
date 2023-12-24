using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TimeScale : MonoBehaviour
{
    // Toggles the time scale between 1 and 0.7
    // whenever the user hits the Fire1 button.

    private float fixedDeltaTime;

    void Awake()
    {
        // Make a copy of the fixedDeltaTime, it defaults to 0.02f, but it can be changed in the editor
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Time.timeScale = 0.3f;
        }
        else if (Input.GetKeyUp(KeyCode.Q))
        {
            Time.timeScale = 1.0f;
        }
    }
}
