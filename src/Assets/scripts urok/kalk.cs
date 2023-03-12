using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;

public class kalk : MonoBehaviour
{
    [SerializeField]
    private InputField _Ia;
    [SerializeField]
    private InputField _Ib;
    //bublik
    [SerializeField]
    private InputField _output;
    [SerializeField]
    private InputField opera;

    private Ariphmetic Ariphmetic = new Ariphmetic();

    public float InpA { get; set; }
    public float InpB { get; set; }
    public Operation Oper;
    public float? Ia => GetNumber(_Ia.text);
    public float? Ib => GetNumber(_Ib.text);
    private void Validate(string res)
    {
        _output.text = res;
    }
    void Start()
    {
        _Ia.onValueChanged.AddListener(ValidateNumber1);
        _Ib.onValueChanged.AddListener(ValidateNumber2);
        opera.onEndEdit.AddListener(ValidateOperator);
    }
    public void ValidateNumber1(string arg)
    {
        var number = GetNumber(arg);

        if (number != null)
        {
            InpA = number.Value;
        }
    }
    public void ValidateNumber2(string arg)
    {
        var number = GetNumber(arg);

        if (number != null)
        {
            InpB = number.Value;
        }
    }
    public void ValidateOperator(string arg)
    {
    if (arg == "-")
        {
            Oper = Operation.Sub;
        }
      else if (arg == "+")
        {
            Oper = Operation.Sum;
        }
        else if (arg == "/")
        {
            Oper = Operation.Div;
        }
        else if (arg == "*")
        {
            Oper = Operation.Mul;
        }
    }
    public void Result()
    {
       opera.text = Ariphmetic.TryGetValue(InpA, InpB, Oper).ToString();
    }
    private float? GetNumber(string text)
    {
        var hasValue = float.TryParse(text, System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out float result);

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
