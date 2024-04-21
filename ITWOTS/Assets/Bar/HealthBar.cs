using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthBar : MonoBehaviour
{

    public float maxValue = 100;
    public Color color = Color.red;
    public int width = 4;
    public Image slider;
    public bool isRight;

    public float current;

    void Start()
    {
       // slider.color = color;
        current = maxValue;

        UpdateUI();
    }

    public float currentValue
    {
        get { return current; }
    }

    void Update()
    {
        if (current < 0) current = 0;
        if (current > maxValue) current = maxValue;

        if (slider != null)
        {
            slider.fillAmount = current / maxValue;
        }
    }
    public void UpdateHealth (float value) 
    {
        current = value;
        UpdateUI();
    }
    void UpdateUI()
    {
        //RectTransform rect = slider.GetComponent<RectTransform>();

        //int rectDeltaX = Screen.width / width;
        //float rectPosX = 0;

        //if (isRight)
        //{
        //    rectPosX = rect.position.x - (rectDeltaX - rect.sizeDelta.x) / 2;
        //    slider.direction = Slider.Direction.RightToLeft;
        //}
        //else
        //{
        //    rectPosX = rect.position.x + (rectDeltaX - rect.sizeDelta.x) / 2;
        //    slider.direction = Slider.Direction.LeftToRight;
        //}

        //rect.sizeDelta = new Vector2(rectDeltaX, rect.sizeDelta.y);
        //rect.position = new Vector3(rectPosX, rect.position.y, rect.position.z);
    }

    public static void AdjustCurrentValue(float adjust)
    {
       // current += adjust;
    }
}