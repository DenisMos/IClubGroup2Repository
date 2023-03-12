using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class USSR
{   private double _value;  
    public void Add(double num)
    {
        _value += num;
    }
    public double minus(double num)
    {
        _value-= num;
        return _value;
      
    }

    
}
