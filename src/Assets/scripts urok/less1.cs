using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class less1: MonoBehaviour
{
    [SerializeField]
    private float resultat;
    // Start is called before the first frame update
    void Start()
    {
        ShowText("Darova");
        var sum = Sum(1, 1.2f);
        ShowText(sum.ToString());
        resultat = sum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowText(string text)
    {
        Debug.Log(text);
    }
    //Целые числа
    int number = -56;
    public float Sum(int n1,float  n2)
    {
        return n1 + n2;
    }
}