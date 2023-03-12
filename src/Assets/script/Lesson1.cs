using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1 : MonoBehaviour
{
    [SerializeField]
    private float _result;
    // Start is called before the first frame update
    void Start()
    {
        var sum = Sum(2, 0.2f);
        ShowText(sum.ToString());
        _result = sum;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void ShowText(string text)
    {
        Debug.Log(text);
    }
    private float Sum(int number1, float @float)
    {
        return number1 + @float;
    }
    
}
