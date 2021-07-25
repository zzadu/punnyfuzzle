using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageRotation : MonoBehaviour
{
    Vector3 screenPos;
    float offset;
    Camera Camera;

    void Start()
    {
        Camera = Camera.main;
    }
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            screenPos = Camera.WorldToScreenPoint(transform.position);
            Vector3 v3 = Input.mousePosition - screenPos;
            offset = (Mathf.Atan2(transform.right.y, transform.right.x) - Mathf.Atan2(v3.y, v3.x)) * Mathf.Rad2Deg;
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 v3 = Input.mousePosition - screenPos;
            float angle = Mathf.Atan2(v3.y, v3.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, 0, angle + offset);
        }
    }
}
