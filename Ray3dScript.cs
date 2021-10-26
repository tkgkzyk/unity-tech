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
        Physics.Raycast(ray, out hit, 1000.0f);

        if (Input.GetMouseButtonDown(0))
        {
            if (hit.collider)
            {
                count++;
                Debug.Log(count);
            }
        }
    }
}
