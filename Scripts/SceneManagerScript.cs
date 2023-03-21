using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerScript : MonoBehaviour
{
    bool NextStage = false;
    bool GameContinue = false;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.GetInt("Clear", 1);
        PlayerPrefs.GetInt("ClearOne", 2);
        PlayerPrefs.GetInt("ClearTwo", 3);
        PlayerPrefs.GetInt("ClearThree", 4);
        PlayerPrefs.GetInt("ClearFour", 5);
        PlayerPrefs.GetInt("ClearFive", 6);
        PlayerPrefs.GetInt("ClearSix", 7);
        PlayerPrefs.GetInt("ClearSeven", 8);
        PlayerPrefs.GetInt("ClearEight", 9);
        PlayerPrefs.GetInt("ClearNine", 10);
        PlayerPrefs.GetInt("ClearTen", 11);
        PlayerPrefs.GetInt("ClearEleven", 12);
        PlayerPrefs.GetInt("ClearTwelve", 13);
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.HasKey("Clear") == true)
        {
            if (NextStage == true)
            {
                SceneManager.LoadScene("Main Scene 1");
            }
                if (GameContinue == true)
                {
                    SceneManager.LoadScene("Main Scene 1");
                }
        }
        if (PlayerPrefs.HasKey("ClearOne") == true)
        {
            if (NextStage == true)
            {
                SceneManager.LoadScene("Main Scene 2");
            }
                if (GameContinue == true)
                {
                    SceneManager.LoadScene("Main Scene 2");
                }
        }
        if (PlayerPrefs.HasKey("ClearTwo") == true)
        {
            if (NextStage == true)
            {
                SceneManager.LoadScene("Main Scene 3");
            }
                if (GameContinue == true)
                {
                    SceneManager.LoadScene("Main Scene 3");
                }
        }
        if (PlayerPrefs.HasKey("ClearThree") == true)
        {
            if (NextStage == true)
            {
                SceneManager.LoadScene("Main Scene 4");
            }
            if (GameContinue == true)
            {
                SceneManager.LoadScene("Main Scene 4");
            }
        }
        if (PlayerPrefs.HasKey("ClearFour") == true)
        {
            if (NextStage == true)
            {
                SceneManager.LoadScene("Main Scene 5");
            }
            if (GameContinue == true)
            {
                SceneManager.LoadScene("Main Scene 5");
            }
        }
        if (PlayerPrefs.HasKey("ClearFive") == true)
        {
            if (NextStage == true)
            {
                SceneManager.LoadScene("Main Scene 6");
            }
            if (GameContinue == true)
            {
                SceneManager.LoadScene("Main Scene 6");
            }
        }
        if (PlayerPrefs.HasKey("ClearSix") == true)
        {
            if (NextStage == true)
            {
                SceneManager.LoadScene("Main Scene 7");
            }
            if (GameContinue == true)
            {
                SceneManager.LoadScene("Main Scene 7");
            }
        }
        if (PlayerPrefs.HasKey("ClearSeven") == true)
        {
            if (NextStage == true)
            {
                SceneManager.LoadScene("Main Scene 8");
            }
            if (GameContinue == true)
            {
                SceneManager.LoadScene("Main Scene 8");
            }
        }
        if (PlayerPrefs.HasKey("ClearEight") == true)
        {
            if (NextStage == true)
            {
                SceneManager.LoadScene("Main Scene 9");
            }
            if (GameContinue == true)
            {
                SceneManager.LoadScene("Main Scene 9");
            }
        }
        if (PlayerPrefs.HasKey("ClearNine") == true)
        {
            if (NextStage == true)
            {
                SceneManager.LoadScene("Main Scene 10");
            }
            if (GameContinue == true)
            {
                SceneManager.LoadScene("Main Scene 10");
            }
        }
        if (PlayerPrefs.HasKey("ClearTen") == true)
        {
            if (NextStage == true)
            {
                SceneManager.LoadScene("Main Scene 11");
            }
            if (GameContinue == true)
            {
                SceneManager.LoadScene("Main Scene 11");
            }
        }
        if (PlayerPrefs.HasKey("ClearEleven") == true)
        {
            if (NextStage == true)
            {
                SceneManager.LoadScene("Main Scene 12");
            }
            if (GameContinue == true)
            {
                SceneManager.LoadScene("Main Scene 12");
            }
        }
        if (PlayerPrefs.HasKey("ClearTwelve") == true)
        {
            if (NextStage == true)
            {
                SceneManager.LoadScene("Complete Scene");
            }
            if (GameContinue == true)
            {
                SceneManager.LoadScene("Complete Scene");
            }
        }

    }

    public void ClickNextStage()
    {
        NextStage = true; 
    }
    public void ClickTopMenu()
    {
        SceneManager.LoadScene("Top Menu Scene");
    }

    public void ClickStart()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Main Scene");
    }

    public void ClickContinue()
    {
        GameContinue = true;
    }

    public void ClickHome()
    {
        SceneManager.LoadScene("Top Menu Scene");
    }

    public void ClickHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay Scene");
    }
}
