using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popakaka : MonoBehaviour
{


    [SerializeField] private MeshRenderer Color;
    [SerializeField] private Color Color1;
    public void SetColorColor()
    {
        Color.material.color = Color1;
    }
    private void Update()
    {
        SetColorColor();
    }

}
