using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockKeeperScript1 : MonoBehaviour
{
    Vector3 BlockKeeper1;
    // Start is called before the first frame update
    void Start()
    {
        BlockKeeper1 = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(BlockKeeper1.x, BlockKeeper1.y - Mathf.Sin(Time.time) * 5.0f, BlockKeeper1.z);
    }
}
