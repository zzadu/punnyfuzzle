using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_Touch : MonoBehaviour
{
    public float Speed = 1;
   
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
             // transform.Rotate(0, 0, -touch.deltaPosition.x);
                transform.Rotate(new Vector3 (0, 0, Speed) * -touch.deltaPosition.x);;
            }
        }
    }
}
