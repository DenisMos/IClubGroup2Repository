using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katana : MonoBehaviour
{
    public Animator animator;
    public int combonum;
    public float reset;
    public float resettime;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("Attack");
        }
    }
}
