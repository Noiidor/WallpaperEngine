using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoiseSliders : MonoBehaviour
{
    [SerializeField] private Slider scaleSlider;
    [SerializeField] private Slider strenghtSlider;
    [SerializeField] private Slider speedSlider;
    [SerializeField] private Slider densitySlider;
    [SerializeField] private Material noiseMaterial;

    private void Start()
    {
        scaleSlider.value = noiseMaterial.GetFloat("_scale");
        strenghtSlider.value = noiseMaterial.GetFloat("_strenght");
        speedSlider.value = noiseMaterial.GetFloat("_speed");
        densitySlider.value = noiseMaterial.GetFloat("_density");
        //noiseMaterial.SetTexture("_BaseMap", new Texture2D(100,100));
    }

    public void scaleChange()
    {
        noiseMaterial.SetFloat("_scale", scaleSlider.value);
    }

    public void strenghtChange()
    {
        noiseMaterial.SetFloat("_strenght", strenghtSlider.value);
    }

    public void speedChange()
    {
        noiseMaterial.SetFloat("_speed", speedSlider.value);
    }

    public void densityChange()
    {
        noiseMaterial.SetFloat("_density", densitySlider.value);
    }
}
