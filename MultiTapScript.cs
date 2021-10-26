using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiTap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var touchCount = Input.touchCount;

        for(var i = 0; i < touchCount; i++)
        {
            var touch = Input.GetTouch(i);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    Debug.Log("touch-began");
                    break;
                case TouchPhase.Moved:
                    Debug.Log("touch-moved");
                    break;
                case TouchPhase.Stationary:
                    Debug.Log("touch-stationary");
                    break;
                case TouchPhase.Ended:
                    Debug.Log("touch-ended");
                    break;
                case TouchPhase.Canceled:
                    Debug.Log("touch-canceled");
                    break;
                default:
                    Debug.Log("not-correct");
                    break;
            }
        }
    }
}
