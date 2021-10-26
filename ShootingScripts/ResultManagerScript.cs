using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultManagerScript : MonoBehaviour
{
    [SerializeField] private Text LastScoreText;
    [SerializeField] private Text HighScoreText;
    private int LastScore;
    private int HighScore;

    // Start is called before the first frame update
    void Start()
    {
        LastScore = PlayerPrefs.GetInt("Score");
        HighScore = PlayerPrefs.GetInt("HighScore");

        if (HighScore < LastScore)
        {
            HighScore = LastScore;
            PlayerPrefs.SetInt("HighScore", LastScore);
        }

        LastScoreText.text = LastScore.ToString();
        HighScoreText.text = HighScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickRetry()
    {
        SceneManager.LoadScene("GameScene");
    }
}
