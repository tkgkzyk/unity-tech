using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCubeScript : MonoBehaviour
{
    //float speed = 5f;
    Vector3 BlockKeeper;

    // Start is called before the first frame update
    void Start()
    {
        //Destroy(this.gameObject, 7.0f);
        BlockKeeper = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position += this.transform.forward * speed * Time.deltaTime;
        transform.position = new Vector3(BlockKeeper.x, BlockKeeper.y, Mathf.Sin(Time.time) * 8.0f + BlockKeeper.z);
    }
}
