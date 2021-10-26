using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies = new GameObject[3];
    private float xMinPos = -13.4f;
    private float xMaxPos = 13.4f;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 5.0f)
        {
            this.transform.position = new Vector3(Random.Range(xMinPos, xMaxPos), 11.8f, 0);
            Instantiate(enemies[Random.Range(0, 3)], this.transform.position, Quaternion.Euler(90, 180, 0));
            timer = 0;
        }
    }
}
