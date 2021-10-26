using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray2dScript : MonoBehaviour
{
    int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit2D hit = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider)
            {
                count++;
                Debug.Log(count);
                Debug.DrawRay(ray.origin, ray.direction * 10, Color.red, 5);
            }
        }
    }
}
