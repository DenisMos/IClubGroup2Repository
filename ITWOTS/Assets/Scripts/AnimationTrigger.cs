using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private string animationTriggerName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInChildren<PlayerMovement>(true) != null)
        {
            animator.SetTrigger(animationTriggerName);
        }
    }

#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1f, 1f, 1f, 0.4f);
        Gizmos.DrawCube(transform.position, transform.localScale);
    }

#endif
}
