using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GradientSliders : MonoBehaviour
{
    private Color color1;
    private Color color2;
    private Color color3;
    private Color color4;
    [SerializeField]private GradientEditor gradient;

    private void Start()
    {
        //gradient = FindObjectOfType<GradientEditor>();

    }

    public void UpdateColor(Slider slider)
    {
        
        if (slider.gameObject.transform.parent.name == "Color1")
        {
            if (slider.gameObject.name == "r")
            {
                color1.r = slider.value;
            }
            else if (slider.gameObject.name == "g")
            {
                color1.g = slider.value;
            }
            else if (slider.gameObject.name == "b")
            {
                color1.b = slider.value;
            }
            gradient.colors[0] = color1;
        }
        else if (slider.gameObject.transform.parent.name == "Color2")
        {
            if (slider.gameObject.name == "r")
            {
                color2.r = slider.value;
            }
            else if (slider.gameObject.name == "g")
            {
                color2.g = slider.value;
            }
            else if (slider.gameObject.name == "b")
            {
                color2.b = slider.value;
            }
            gradient.colors[1] = color2;
        }
        else if (slider.gameObject.transform.parent.name == "Color3")
        {
            if (slider.gameObject.name == "r")
            {
                color3.r = slider.value;
            }
            else if (slider.gameObject.name == "g")
            {
                color3.g = slider.value;
            }
            else if (slider.gameObject.name == "b")
            {
                color3.b = slider.value;
            }
            gradient.colors[2] = color3;
        }
        else if (slider.gameObject.transform.parent.name == "Color4")
        {
            if (slider.gameObject.name == "r")
            {
                color4.r = slider.value;
            }
            else if (slider.gameObject.name == "g")
            {
                color4.g = slider.value;
            }
            else if (slider.gameObject.name == "b")
            {
                color4.b = slider.value;
            }
            gradient.colors[3] = color4;
        }
        UpdateColorImg();
    }

    public void UpdateColorImg()
    {

    }

    public void UpdateGradientImg()
    {

    }
}
