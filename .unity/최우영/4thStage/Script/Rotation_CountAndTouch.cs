using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_CountAndTouch : MonoBehaviour
{
    public float Speed = 1;
    public static int tCount;
    public int startCount = 0;
    public int addCount = 1;

    void Start()
    {
        tCount = startCount;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.Rotate(new Vector3(0, 0, Speed) * -touch.deltaPosition.x);
                tCount = tCount + addCount;
            }
        }
    }
}

