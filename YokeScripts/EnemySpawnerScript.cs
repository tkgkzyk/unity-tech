using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    [serializedField] private GameObject Enemy;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 1)
        {
            Instantiate(Enemy, this.transform.position + this.transform.right * Random.Range(-10.0f, 10.0f), this.transform.rotation);
            timer = 0;
        }
    }
}
