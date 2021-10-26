using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float jumpPower = 5.0f;
    private Animator animator;
    [SerializeField] private AudioClip jumpsound;
    [SerializeField] private AudioClip itemsound;
    private AudioSource audioSource;
    private bool RightMove;
    private bool LeftMove;
    [SerializeField] private Image hpimage;
    private float maxHP = 5;
    private float currentHP = 5;
    private int jumpCount;


    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        audioSource = this.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey("right") == true || RightMove == true)
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            this.transform.rotation = Quaternion.Euler(0, 90, 0);
        }
        if (Input.GetKey("left") == true || LeftMove == true)
        {
            this.transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            this.transform.rotation = Quaternion.Euler(0, 270, 0);
        }
        if (Input.GetKeyDown("space") == true)
        {
            JumpButtonDown();
        }


        if (Input.GetKeyDown("right"))
        {
            animator.SetBool("Running", true);
        }
        if (Input.GetKeyUp("right"))
        {
            animator.SetBool("Running", false);
        }

        if (Input.GetKeyDown("left"))
        {
            animator.SetBool("Running", true);
        }
        if (Input.GetKeyUp("left"))
        {

            animator.SetBool("Running", false);
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Item")
        {
            audioSource.clip = itemsound;
            audioSource.Play();
            Destroy(col.gameObject);

            if(currentHP < 5)
            {
                currentHP += 1;
                hpimage.fillAmount = currentHP / maxHP;
            }

        }
        if (col.gameObject.tag == "Ground")
        {
            jumpCount = 0;
        }
        if(col.gameObject.tag == "Enemy")
        {
            currentHP -= 1;
            hpimage.fillAmount = currentHP / maxHP;
            Destroy(col.gameObject);

            if (currentHP == 0)
            {
                SceneManager.LoadScene("EndScene");
            }
        }
    }
    public void RightButtonDown()
    {
        RightMove = true;
        animator.SetBool("Running", true);
    }

    public void RightButtonUp()
    {
        RightMove = false;
        animator.SetBool("Running", false);
    }

    public void LeftButtonDown()
    {
        LeftMove = true;
        animator.SetBool("Running", true);
    }

    public void LeftButtonUp()
    {
        LeftMove = false;
        animator.SetBool("Running", false);
    }

    public void JumpButtonDown()
    {
        if (jumpCount < 2)
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            audioSource.clip = jumpsound;
            audioSource.Play();
            jumpCount += 1;
        }
    }
}
