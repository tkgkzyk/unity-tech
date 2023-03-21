using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalKeeperScript : MonoBehaviour
{
    public float speed = 10f;
    Animator animator;
    //int ShootNumber;

    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    public void Update()
    {

    }
    IEnumerator Rotation()
    {
        yield return new WaitForSeconds(3);
        this.transform.rotation = Quaternion.Euler(0, 90, 0);
    }

public void ClickRightLow()
    {
        animator.SetBool("KeeperDiveRightLow", true);
    }

    public void ClickLeftLow()
    {
        animator.SetBool("KeeperDiveLeftLow", true);
    }

    public void ClickRightHigh()
    {
        animator.SetBool("KeeperDiveRightHigh", true);

        StartCoroutine("Rotation");
    }

    public void ClickLeftHigh()
    {
        animator.SetBool("KeeperDiveLeftHigh", true);

        StartCoroutine("Rotation");
    }
    public void ClickCenterLow()
    {
        animator.SetBool("KeeperDiveCenterLow", true);
    }

    public void ClickCenterHigh()
    {
        animator.SetBool("KeeperDiveCenterHigh", true);
    }
}
