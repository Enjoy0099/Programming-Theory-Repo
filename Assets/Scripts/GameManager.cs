using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float red, green, blue;

    protected float random_Cube, select_Cube;
    protected float Red
    {
        get { return red; }
        set {
            if (value < 0f)
                value = 0f;
            else if (value > 1f)
                value = 1f;
            red = value; 
        }
    }

    protected float Green
    {
        get { return green; }
        set {
            if (value < 0f)
                value = 0f;
            else if (value > 1f)
                value = 1f;
            green = value; 
        }
    }

    protected float Blue
    {
        get { return blue; }
        set {
            if (value < 0f)
                value = 0f;
            else if (value > 1f)
                value = 1f;
            blue = value; 
        }
    }

    [SerializeField]
    private MeshRenderer randomCube, chooseCube;

    private void Awake()
    {
        SetColorValue();
    }

    protected void SetColorValue()
    {
        RandomColor();
        Red = (float)Random.Range(0, 11) / 10;
        Green = (float)Random.Range(0, 11) / 10;
        Blue = (float)Random.Range(0, 11) / 10;
        chooseCube.material.color = new Color(Red, Green, Blue);
    }

    public void RandomColor()
    {
        randomCube.material.color = new Color((float)Random.Range(0, 11) / 10,
                                              (float)Random.Range(0, 11) / 10,
                                              (float)Random.Range(0, 11) / 10);
        random_Cube = ColorToFloat(randomCube.material.color);
    }

    public void SetColor()
    {
        chooseCube.material.color = new Color(red, green, blue);
        select_Cube = ColorToFloat(chooseCube.material.color);

        Debug.Log(chooseCube.material.color);
        Debug.Log(randomCube.material.color);
    }
    
    public float ColorToFloat(Color color)
    {
        float a = float.Parse((color.r + color.g + color.b).ToString("0.00"));
        return a;
    }

}
