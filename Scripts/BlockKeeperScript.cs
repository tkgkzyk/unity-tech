using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockKeeperScript : MonoBehaviour
{
    //float speed = 5f;
    //float Timer;
    Vector3 BlockKeeper;
    // Start is called before the first frame update
    void Start()
    {
        BlockKeeper = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(BlockKeeper.x, BlockKeeper.y, Mathf.Sin(Time.time) * 10.0f + BlockKeeper.z);
    }
}

