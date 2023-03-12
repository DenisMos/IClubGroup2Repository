using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kalkulator : MonoBehaviour
{
    [Header("Число 1")]
    [SerializeField]
    private float InputA;

    [Header("Число 2")]
    [SerializeField]
    private float InputB;

    [Header("Число1+2Число")]
    [SerializeField]
    private float ASumB;

    [Header("Число1-Число2")]
    [SerializeField]
    private float ASubB;

    [Header("Число1/Число2")]
    [SerializeField]
    private float ADivB;

    [Header("Число1*Число2")]
    [SerializeField]
    private float AMulB;

    void Update()
    {
        ASumB = InputA + InputB;

        ASubB = InputA - InputB;

        ADivB = InputA / InputB;

        AMulB = InputA * InputB;

    }
}
