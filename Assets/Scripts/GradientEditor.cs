// requires this script: https://github.com/UnityCommunity/UnityLibrary/blob/master/Assets/Scripts/Texture/GradientTextureMaker.cs
using UnityEngine;

public class GradientEditor : MonoBehaviour
{
    public Color[] colors = new Color[4];

    public FilterMode filterMode = FilterMode.Point;
    public TextureWrapMode wrapMode = TextureWrapMode.Clamp;
    public bool isLinear = false;
    public bool hasMipMap = false;
    private Material mat;

    void Start()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        mat = renderer.material;
        UpdateGradient();
    }

    public void UpdateGradient()
    {
        Texture2D texture = UnityLibrary.GradientTextureMaker.Create(colors, wrapMode, filterMode, isLinear, hasMipMap);
        mat.SetTexture("_gradient", texture);
    }

}