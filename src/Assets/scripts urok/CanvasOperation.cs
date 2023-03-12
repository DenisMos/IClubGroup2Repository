using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class CanvasOperation : MonoBehaviour
{
    [SerializeField]
    private InputField InputA;

    [SerializeField]
    private InputField InputB;

    [SerializeField]
    private InputField InputOper;

    [SerializeField]
    private InputField Result;

    private float? GetNumber(string text)
    {
       var hasValue= float.TryParse(text, System.Globalization.NumberStyles.Float, CultureInfo.InvariantCulture, out float result);

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
