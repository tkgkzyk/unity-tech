using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
    private float speed = 5.0f;
    private int score;
    private string[] enemies = new string[4] { "Bullet", "Red", "Yellow", "Purple"};
    private Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GameObject.Find("Score").GetComponent<Text>();
        score = PlayerPrefs.GetInt("Score");
        Destroy(this.gameObject, 7.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += new Vector3(0, speed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        for(int i = 0; i < enemies.Length; i++)
        {
            if(collision.gameObject.tag == enemies[i])
            {
                score += (i + 1) * 5;
            }
        }

        if (collision.gameObject.tag != "Player")
        {
            ScoreText.text = score.ToString();
            PlayerPrefs.SetInt("Score", score);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
