using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDie : MonoBehaviour
{
    public Counter Counter;
    public int Point = 1;

    private void OnDestroy()
    {
        Counter?.OnEvent(Point);
    }
}
