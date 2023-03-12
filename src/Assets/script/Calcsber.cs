using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Calcsber : MonoBehaviour
{
    [SerializeField]
    private InputField _inputA;
    [SerializeField]
    private InputField _inputB;
    [SerializeField]
    private InputField _operation;
    [SerializeField]
    private InputField _OUTPUTE;
    private Ariphmetic Ariphmetic = new Ariphmetic();
    public float? InputA
    { get; set; }

    public float? InputB
    { get; set; }
    public Operation Operation;


    // Start is called before the first frame update
    void Start()
    {
        _inputA.onEndEdit.AddListener(ValidateNumber1);
        _inputB.onEndEdit.AddListener(ValidateNumber2);
        _operation.onEndEdit.AddListener(OperationMethod);
    }

    public void ValidateNumber1(string arg)
    {
        var number = GetNumber(arg);

        if(number != null)
        {
            Debug.Log(number);
            InputA = number.Value;
        }
    }

    public void ValidateNumber2(string arg)
    {
        var number = GetNumber(arg);

        if (number != null)
        {
            Debug.Log(number);
            InputB = number.Value;
        }
    }

    public void OperationMethod(string arg)
    { 
        if(arg == "+")
        {
            Operation = Operation.Sum;
        }
        else if (arg == "-")
        {
            Operation = Operation.Sub;
        }
        else if (arg == "*")
        {
            Operation = Operation.mul;
        }
        else if (arg == "/")
        {
            Operation = Operation.div;
        }
    }

    public void Result()
    {
        _OUTPUTE.text = Ariphmetic.TryGetValue(InputA.Value, InputB.Value, Operation).ToString();
    }

    public float? GetNumber(string num)
    {
        var hasValue = float.TryParse(
            num,
            System.Globalization.NumberStyles.Float,
            System.Globalization.CultureInfo.InvariantCulture,
            out float result);
        if (hasValue)
        {
            return result;
        }
        else
        {
            return null;
        }
    }
}
