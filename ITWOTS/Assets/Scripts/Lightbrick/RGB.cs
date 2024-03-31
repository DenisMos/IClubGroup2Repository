using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGB : MonoBehaviour
{
    public new MeshRenderer light;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var b = (Mathf.Cos(Time.time) + 1) / 2;
        var r = (Mathf.Sin(Time.time) + 1) / 2;
        light.material.color = new Color(r,0,b);
    }
}
