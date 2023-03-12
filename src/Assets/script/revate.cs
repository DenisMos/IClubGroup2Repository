using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revate : MonoBehaviour
{

    /// <summary>
    /// это €чейка банка
    /// </summary>
    [SerializeField]
    [Header("Number1")]
    private float _number1;
    /// <summary>
    /// булочка с маком 
    /// </summary>
    [SerializeField]
    [Header("Number2")]
    private string _number2;
  /// <summary>
  /// свойство 
  /// </summary>
    public float Timyrleo
    {
        get
        {
            return _number1;
        }
        set
        {
            _number1 = value - 1;
            _number2 = Sum;
        }
    }
    private string Sum
    {
        get
        {
            return _number1.ToString();
        }
    }

    private void Start()
    {
        Add(800000);
        //Mem = new USSR();
    }
    private float Add( float num)
    {
        Timyrleo += num;
        return Timyrleo;
    }

}
