using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Machete : MonoBehaviour
{
    private bool beat;
    void Update()
    {
        beat = Input.GetMouseButtonDown(0);
    }
}
