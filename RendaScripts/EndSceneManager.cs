using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndSceneManager : MonoBehaviour
{
    [SerializeField] private Text LastScoreText;
    [SerializeField] private Text HighScoreText;
    private int LastScore;
    private int HighScore;

    void Start()
    {
        LastScore = PlayerPrefs.GetInt("score");
        HighScore = PlayerPrefs.GetInt("HighScore");

        if (PlayerPrefs.HasKey("HighScore") == true)
        {

            if (HighScore < LastScore)
            {
                HighScore = LastScore;
                PlayerPrefs.SetInt("HighScore", LastScore);
            }
        }

        else
        {
            HighScore = LastScore;
            PlayerPrefs.SetInt("HighScore", HighScore);
        }

        LastScoreText.text = LastScore.ToString();
        HighScoreText.text = HighScore.ToString();
    }

    private void Update()
    {
       
    }

    public void RetryButton()
    {
        SceneManager.LoadScene("StartScene");
    }

}
