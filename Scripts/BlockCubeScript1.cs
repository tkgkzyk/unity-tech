using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockCubeScript1 : MonoBehaviour
{
    public GameObject BlockCube;
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

        //Timer += Time.deltaTime;

        //if(Timer > 2f)
        //{
            //Instantiate(BlockCube, this.transform.position, this.transform.rotation);
            //Timer = 0;
            transform.position = new Vector3(BlockKeeper.x, BlockKeeper.y, BlockKeeper.z - Mathf.Sin(Time.time) * 10.0f);
        //}
    }
}
