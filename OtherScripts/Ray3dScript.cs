using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray3dScript : MonoBehaviour
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
        RaycastHit hit;
        Physics.Raycast(ray, out hit, 10.0f);

        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider)
            {
                count++;
                Debug.Log(count);
            }
        }

        Debug.DrawRay(ray.origin, ray.direction * 10, Color.red, 5); //Rayの描写

        /*オブジェクトが複数存在する時

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        foreach (RaycastHit hit in Physics.RaycastAll(ray))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider)
                {
                    count++;
                    Debug.Log(count);
                }
            }
        }*/
    }
}
