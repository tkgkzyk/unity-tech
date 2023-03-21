using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallScript : MonoBehaviour
{
    float speed = 40f;
    bool shoot = false;
    //int KeeperNumber;
    //int ShootNumber;
    bool Resets = false;
    //int ClearResult;
    //int Failure;

    // Start is called before the first frame update
    public void Start()
    {
        //KeeperNumber = Random.Range(1, 7);
    }

    // Update is called once per frame
    void Update()
    {

        if (shoot == true)
        {
            this.transform.position += this.transform.forward * speed * Time.deltaTime;
            StartCoroutine("Reset");
        }

        if (Resets == true)
        {
            if (SceneManager.GetActiveScene().name == "HowToPlay Scene")
            {
                SceneManager.LoadScene("Top Menu Scene");
            }

            if (SceneManager.GetActiveScene().name == "Main Scene")
            {
                SceneManager.LoadScene("Repeat Scene");
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 1")
            {
                SceneManager.LoadScene("Repeat Scene 1");
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 2")
            {
                SceneManager.LoadScene("Repeat Scene 2");
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 3")
            {
                SceneManager.LoadScene("Repeat Scene 3");
            }
            if (SceneManager.GetActiveScene().name == "Main Scene 4")
            {
                SceneManager.LoadScene("Repeat Scene 4");
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 5")
            {
                SceneManager.LoadScene("Repeat Scene 5");
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 6")
            {
                SceneManager.LoadScene("Repeat Scene 6");
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 7")
            {
                SceneManager.LoadScene("Repeat Scene 7");
            }
            if (SceneManager.GetActiveScene().name == "Main Scene 8")
            {
                SceneManager.LoadScene("Repeat Scene 8");
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 9")
            {
                SceneManager.LoadScene("Repeat Scene 9");
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 10")
            {
                SceneManager.LoadScene("Repeat Scene 10");
            }
            if (SceneManager.GetActiveScene().name == "Main Scene 11")
            {
                SceneManager.LoadScene("Repeat Scene 11");
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 12")
            {
                SceneManager.LoadScene("Repeat Scene 12");
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene")
            {
                SceneManager.LoadScene("Main Scene");
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 1")
            {
                SceneManager.LoadScene("Main Scene 1");
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 2")
            {
                SceneManager.LoadScene("Main Scene 2");
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 3")
            {
                SceneManager.LoadScene("Main Scene 3");
            }
            if (SceneManager.GetActiveScene().name == "Repeat Scene 4")
            {
                SceneManager.LoadScene("Main Scene 4");
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 5")
            {
                SceneManager.LoadScene("Main Scene 5");
            }

            if (SceneManager.GetActiveScene().name == "Reoeat Scene 6")
            {
                SceneManager.LoadScene("Main Scene 6");
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 7")
            {
                SceneManager.LoadScene("Main Scene 7");
            }
            if (SceneManager.GetActiveScene().name == "Repeat Scene 8")
            {
                SceneManager.LoadScene("Main Scene 8");
            }

            if (SceneManager.GetActiveScene().name == "Reoeat Scene 9")
            {
                SceneManager.LoadScene("Main Scene 9");
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 10")
            {
                SceneManager.LoadScene("Main Scene 10");
            }
            if (SceneManager.GetActiveScene().name == "Reoeat Scene 11")
            {
                SceneManager.LoadScene("Main Scene 11");
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 12")
            {
                SceneManager.LoadScene("Main Scene 12");
            }
        }
    }

    public void ShootCenterDown()
    {
        //ShootNumber = 4;
        shoot = true;
    }
    public void ShootCenterUp()
    {
        //ShootNumber = 3;
        this.transform.rotation = Quaternion.Euler(-15, -90, 0);
        shoot = true;
    }

    public void ShootRightUp()
    {
        //ShootNumber = 5;
        this.transform.rotation = Quaternion.Euler(-15, -75, 0);
        shoot = true;
    }
    public void ShootRightDown()
    {
        //ShootNumber = 6;
        this.transform.rotation = Quaternion.Euler(0, -75, 0);
        shoot = true;
    }
    public void ShootLeftUp()
    {
        //ShootNumber = 1;
        this.transform.rotation = Quaternion.Euler(-15, -105, 0);
        shoot = true;
    }
    public void ShootLeftDown()
    {
        //ShootNumber = 2;
        this.transform.rotation = Quaternion.Euler(0, -105, 0);
        shoot = true;
    }

    public void DecideDirectionLeft()
    {
        Vector3 tmp = GameObject.Find("Soccer Ball").transform.position;
        GameObject.Find("Soccer Ball").transform.position = new Vector3(tmp.x ,tmp.y,tmp.z -1);
    }
    public void DecideDirectionForward()
    {
        Vector3 tmp = GameObject.Find("Soccer Ball").transform.position;
        GameObject.Find("Soccer Ball").transform.position = new Vector3(tmp.x - 1, tmp.y, tmp.z);
    }
    public void DecideDirectionRight()
    {
        Vector3 tmp = GameObject.Find("Soccer Ball").transform.position;
        GameObject.Find("Soccer Ball").transform.position = new Vector3(tmp.x, tmp.y, tmp.z + 1);
    }

    //private Rigidbody rigidbody;
    public IEnumerator Reset()
    {
        yield return new WaitForSeconds(5);
        Resets = true;
    }
    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Goal")
            //{
            //if (KeeperNumber == ShootNumber)
            //{
            //Debug.Log("Save");
            //}
        {

            if (SceneManager.GetActiveScene().name == "Main Scene")
            {
                PlayerPrefs.SetInt("Clear", 1);
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene")
            {
                PlayerPrefs.SetInt("Clear", 1);
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 1")
            {
                PlayerPrefs.SetInt("ClearOne", 2);
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 1")
            {
                PlayerPrefs.SetInt("ClearOne", 2);
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 2")
            {
                PlayerPrefs.SetInt("ClearTwo", 3);
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 2")
            {
                PlayerPrefs.SetInt("ClearTwo", 3);
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 3")
            {
                PlayerPrefs.SetInt("ClearThree", 4);
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 3")
            {
                PlayerPrefs.SetInt("ClearThree", 4);
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 4")
            {
                PlayerPrefs.SetInt("ClearFour", 5);
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 4")
            {
                PlayerPrefs.SetInt("ClearFour", 5);
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 5")
            {
                PlayerPrefs.SetInt("ClearFive", 6);
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 5")
            {
                PlayerPrefs.SetInt("ClearFive", 6);
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 6")
            {
                PlayerPrefs.SetInt("ClearSix", 7);
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 6")
            {
                PlayerPrefs.SetInt("ClearSix", 7);
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 7")
            {
                PlayerPrefs.SetInt("ClearSeven", 8);
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 7")
            {
                PlayerPrefs.SetInt("ClearSeven", 8);
            }
            if (SceneManager.GetActiveScene().name == "Main Scene 8")
            {
                PlayerPrefs.SetInt("ClearEight", 9);
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 8")
            {
                PlayerPrefs.SetInt("ClearEight", 9);
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 9")
            {
                PlayerPrefs.SetInt("ClearNine", 10);
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 9")
            {
                PlayerPrefs.SetInt("ClearNine", 10);
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 10")
            {
                PlayerPrefs.SetInt("ClearTen", 11);
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 10")
            {
                PlayerPrefs.SetInt("ClearTen", 11);
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 11")
            {
                PlayerPrefs.SetInt("ClearEleven", 12);
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 11")
            {
                PlayerPrefs.SetInt("ClearEleven", 12);
            }

            if (SceneManager.GetActiveScene().name == "Main Scene 12")
            {
                PlayerPrefs.SetInt("ClearTwelve", 13);
            }

            if (SceneManager.GetActiveScene().name == "Repeat Scene 12")
            {
                PlayerPrefs.SetInt("ClearTwelve", 13);
            }

            if (SceneManager.GetActiveScene().name == "HowToPlay Scene")
            {
                SceneManager.LoadScene("Top Menu Scene");
            }
            else

            SceneManager.LoadScene("Result Scene");
        }
        //else

        //Debug.Log("Goal");

        //}
    }
}
