using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class SetColorForCube : MyColor
{
    public MeshRenderer _ChooseCube;

    private float _r, _g, _b;

    private void Awake()
    {
        _r = _g = _b = 0;
    }
    public void AddRed()
    {
        _r = _r + 0.1f;
        Red = _r;
        Setcolor_Cube(_ChooseCube);
    }
    public void SubstractRed()
    {
        _r = _r - 0.1f;
        Red = _r;
        Setcolor_Cube(_ChooseCube);
    }

    public void AddGreen()
    {
        _g = _g + 0.1f;
        Green = _g;
        Setcolor_Cube(_ChooseCube);
    }
    public void SubstractGreen()
    {
        _g = _g - 0.1f;
        Green = _g;
        Setcolor_Cube(_ChooseCube);
    }

    public void AddBlue()
    {
        _b = _b + 0.1f;
        Blue = _b;
        Setcolor_Cube(_ChooseCube);
    }
    public void SubstractBlue()
    {
        _b = _b - 0.1f;
        Blue = _b;
        Setcolor_Cube(_ChooseCube);
    }
}
