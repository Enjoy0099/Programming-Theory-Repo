using UnityEngine;

[DefaultExecutionOrder(10)]
public class SetRandomColorToCube : MyColor
{
    private Renderer myMaterial;

    private void Awake()
    {

        myMaterial = GetComponent<Renderer>();
        
        RandomColor();

        SetRandomColor();
    }

    private void SetRandomColor()
    {
        myMaterial.material.color = RColor;
    }
}
