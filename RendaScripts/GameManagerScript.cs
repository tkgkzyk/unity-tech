using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    private int count;
    [SerializeField] private Text countText;
    [SerializeField] private Text timerText;
    private float timer = 10.0f;
    [SerializeField] private public Text buttonText;
    [SerializeField] private GameObject rendaSound;
    priavte bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        buttonText.text = "Start";
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlaying == true)
        {
            timer -= Time.deltaTime;
            timerText.text = timer.ToString("f2");
        }

        if(timer < 0)
        {
            isPlaying = false;
            timer = 0;
            timerText.text = timer.ToString("f2");
            buttonText.text = "End";

            PlayerPrefs.SetInt("score", count);
            SceneManager.LoadScene("EndScene");
        }

    }

    public void Countup()
    {
        if (isPlaying == true)
        {
            count ++;
            countText.text = count.ToString();

	　　GameObject rendaSoundClone = Instantiate(rendaSound)as GameObject;
	　　Destroy(rendaSoundClone, 3.0f);
            Debug.Log(count);
        }
        else
        {
            isPlaying = true;
            buttonText.text = "Push";
            countText.text = "0";
        }
    }

}
