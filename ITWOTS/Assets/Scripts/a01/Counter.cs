using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public GameObject Doors;
    public int MaxPoint;
    private int _currentPoint;

    public void OnEvent(int point)
    {
        _currentPoint += point;

        if (_currentPoint > MaxPoint)
        {
            if (Doors != null)
            {
                Doors.GetComponent<door1>().Open();
            }
        }
    }
}
