using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_StarT : MonoBehaviour
{
    public static int stars = 0;
    public string targetObjectName;

    void Start()
    {
        stars = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            stars += 1;
            this.gameObject.SetActive(false);
        }
    }
}
