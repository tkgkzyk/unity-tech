using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private float Speed = 0.5f;
    private float timer;
    [SerializeField] private GameObject EnemyBullet;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 30.0f);
    }
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        this.transform.position -= new Vector3(0, YellowSpeed * Time.deltaTime, 0);

        if (timer > 3.0f)
        {
            Instantiate(EnemyBullet, this.transform.position, Quaternion.Euler(0, 0, 0));
            timer = 0;
        }
    }
}
