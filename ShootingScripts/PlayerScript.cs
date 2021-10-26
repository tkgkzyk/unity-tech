using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    private float speed = 5f;
    [SerializeField] GameObject Bullet;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteKey("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
        }

        timer += Time.deltaTime;

        if (Input.GetKey("space"))
        {
            if (timer > 1.0f)
            {
                Instantiate(Bullet, this.transform.position, Quaternion.Euler(0,0,0));
                timer = 0;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            SceneManager.LoadScene("ResultScene");
        }
    }
}
