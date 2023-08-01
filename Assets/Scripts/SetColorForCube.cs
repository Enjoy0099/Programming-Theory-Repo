using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

[DefaultExecutionOrder(100)]
public class SetColorForCube : MyColor
{
    private MeshRenderer _ChooseCube;

    private void Awake()
    {
        Red = Green = Blue = 0.5f;
        _ChooseCube = GetComponent<MeshRenderer>();
    }
    public void AddRed()
    {
        Red += 0.1f;
        Setcolor_Cube(_ChooseCube);
    }
    public void SubstractRed()
    {
        Red -= 0.1f;
        Setcolor_Cube(_ChooseCube);
    }

    public void AddGreen()
    {
        Green += 0.1f;
        Setcolor_Cube(_ChooseCube);
    }
    public void SubstractGreen()
    {
        Green -= 0.1f;
        Setcolor_Cube(_ChooseCube);
    }

    public void AddBlue()
    {
        Blue += 0.1f;
        Setcolor_Cube(_ChooseCube);
    }
    public void SubstractBlue()
    {
        Blue -= 0.1f;
        Setcolor_Cube(_ChooseCube);
    }
}
