using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class PointMoving : MonoBehaviour
{
    public Vector3[] Target;
    private int _pointer;

    void FixedUpdate()
    {
        var targetPosition = Target[_pointer];
        var distance = Vector2.Distance(transform.position, targetPosition);
        transform.position = Vector3.Lerp(transform.position, targetPosition, 1 / distance * Time.fixedDeltaTime);
        if (distance <= 0.1f)
        {
            _pointer++;
            if (_pointer >= Target.Length)
            {
                _pointer = 0;
            }
        }

    }
    private void OnDrawGizmosSelected()
    {
        var oldPositin = transform.position;
        foreach (var item in Target)
        {
            Gizmos.DrawLine(oldPositin, item);
            var pos = Vector2.Lerp(oldPositin, item, 0.5f);
            var dist = Vector2.Distance(oldPositin, item);
            oldPositin = item;
            Gizmos.DrawCube(item, Vector2.one / 5);
            Handles.Label(pos, dist.ToString());
        }
    }

}
