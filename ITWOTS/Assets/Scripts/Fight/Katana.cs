using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katana : MonoBehaviour
{
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
        }
    }
    public void AttEventF()
    {
        animator.SetBool("CanAttack", false);
        animator.SetBool("CanAttack1", true);
    }
    public void AttEventT()
    {
        animator.SetBool("CanAttack", true);
        animator.SetBool("CanAttack1", false);
    }
    public void AttEvent1F()
    {
        animator.SetBool("CanAttack1", false);
    }

}
