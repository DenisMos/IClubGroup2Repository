using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleWalls : MonoBehaviour
{
#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(0.7f, 0.7f, 0.9f, 0.5f);
        Gizmos.DrawCube(transform.position, transform.localScale);
    }

#endif
}
