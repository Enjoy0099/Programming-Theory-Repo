using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(0)]
public class MyColor : MonoBehaviour
{

    private float _red,_green,_blue;

    private Color _color;
    public float Red
    {
        get { return _red; }
        set 
        {
            if (value < 0)
                value = 0;
            else if (value > 1)
                value = 1;
            _red = value; 
        }
    }

    public float Green
    { 

        get { return _green; }
        set 
        {
            if (value < 0)
                value = 0;
            else if (value > 1)
                value = 1;
            _green = value; 
        }
    }


    public float Blue
    {
        get { return _blue; }
        set 
        {
            if (value < 0)
                value = 0;
            else if (value > 1)
                value = 1;
            _blue = value; 
        }
    }

    public Color RColor
    {
        get { return _color;}
        set { _color = value; }
    }


    protected void RandomColor()
    {
        RColor = new Color((float)Random.Range(0, 11) / 10, (float)Random.Range(0, 11) / 10, (float)Random.Range(0, 11) / 10);
    }

    protected void Setcolor_Cube(MeshRenderer setcube)
    {
        setcube.material.color = new Color(_red, _green, _blue);
    }

}
