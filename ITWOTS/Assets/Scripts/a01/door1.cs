using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door1 : MonoBehaviour
{
    public Animator animator;

    public void Open()
    {
        animator.SetTrigger("IsOpens");
    }
}
