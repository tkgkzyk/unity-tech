using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    private float Speed = 5.0f;
    private GameObject player;
    private Vector3 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        playerPos = player.transform.position;
        Destroy(this.gameObject, 7.0f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, playerPos, Time.deltaTime * Speed);
    }
}
