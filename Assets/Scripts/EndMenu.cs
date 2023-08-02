#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;

public class EndMenu : MonoBehaviour
{
    
    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
