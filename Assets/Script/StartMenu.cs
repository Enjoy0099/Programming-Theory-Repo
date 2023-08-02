#if UNITY_EDITOR
using UnityEditor;
#endif
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public TextMeshProUGUI PlayerName_Text;
    public TextMeshProUGUI Welcome_Text;
    public GameObject Enter_Name;

    public string Player_Name;

    private void Awake()
    {
        Load_PlayerName();
    }


    [System.Serializable]   
    private class PlayerNameClass
    {
        public string playerName;
    }

    public void Save_PlayerName(string playername)
    {
        PlayerNameClass pname = new PlayerNameClass();
        pname.playerName = playername;

        string json = JsonUtility.ToJson(pname);

        File.WriteAllText(Application.persistentDataPath + "/PlayerName.json", json);
    }

    public void Load_PlayerName()
    {
        string path = Application.persistentDataPath + "/PlayerName.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerNameClass data = JsonUtility.FromJson<PlayerNameClass>(json);

            Player_Name = data.playerName;
            PlayerName_Text.text = data.playerName;

            Enter_Name.SetActive(false);
            Welcome_Text.gameObject.SetActive(true);

            Welcome_Text.text = "welcome, " + Player_Name;
        }
    }


    public void Start_Game()
    {
        if(PlayerName_Text.text.Length > 1)
        {
            Save_PlayerName(PlayerName_Text.text);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            Enter_Name.SetActive(false);
            Welcome_Text.gameObject.SetActive(true);
        }
        
    }


    public void ChangeName()
    {
        Enter_Name.SetActive(true);
        Welcome_Text.gameObject.SetActive(false);
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
