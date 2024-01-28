using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katana : MonoBehaviour
{
    List<string> animList = new List<string>(new string[] {"Attack", "Attack1", "Attack2"});
    public Animator animator;
    public int combonum;
    public float reset;
    public float resettime;

    private void Update()
    {
        if(Input.GetButton("Fire1") && combonum < 3)
        {
            animator.SetTrigger(animList[combonum]);
            combonum++;
            reset = 0f;
        }
        if(combonum > 0)
        {
            reset += Time.deltaTime;
            if(reset > resettime)
            {
                animator.SetTrigger("Reset");
                combonum = 0;  
            }
        }
        if (combonum == 3)
        {
            resettime = 3f;
            combonum = 0;
        }
        else
        {
            resettime = 1f;
        }
    }
}
