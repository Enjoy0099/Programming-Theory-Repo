using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : GameManager
{
    [SerializeField] private TextMeshProUGUI score_Text;
    [SerializeField] private TextMeshProUGUI feedback_Text;

    [SerializeField]
    private Animator refreshScreen;

    private int score_Count = 0;
    public void AddRed()
    {
        Red += 0.1f;
        SetColor();
    }

    public void AddGreen()
    {
        Green += 0.1f;
        SetColor();
    }

    public void AddBlue()
    {
        Blue += 0.1f;
        SetColor();
    }

    public void SubRed()
    {
        Red -= 0.1f;
        SetColor();
    }

    public void SubGreen()
    {
        Green -= 0.1f;
        SetColor();
    }

    public void SubBlue()
    {
        Blue -= 0.1f;
        SetColor();
    }

    public void CheckMatch()
    {
        refreshScreen.gameObject.SetActive(true);

        if(random_Cube == select_Cube)
        {
            score_Text.text = "Score: " + (++score_Count).ToString("00");
            if(score_Count == 10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                feedback_Text.text = "A mere " + (10 - score_Count) + " steps separate you from glory's embrace.";
            }
            Invoke("SetColorValue", 2f);
        }
        else
        {
            score_Text.text = "Score: 00";
            
            feedback_Text.text = "It seems the colors weren't in your favor this time. Better luck next round!";
        }

        refreshScreen.Play("RefreshScreen");

    }


    public void BackToStartMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
