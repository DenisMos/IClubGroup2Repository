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
        if (other.CompareTag("TriggerActivator"))
        {
            animator.SetTrigger(animationTriggerName);
        }
    }
}
