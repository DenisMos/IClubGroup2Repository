using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ariphmetic 
{
    public float? TryGetValue(float v1, float v2, Operation operation)
    {
        switch(operation)
        {
            case Operation.Sum:
                return v1 + v2;
            case Operation.Sub:
                return v1 - v2;
            case Operation.mul:
                return v1 * v2;
            case Operation.div:
                return v1 / v2;


        }
        return null;
    }
}

public enum Operation
{
    Sum,
    div,
    mul,
    Sub,
}
