using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star : MonoBehaviour
{
    public static int starNumber;
    public string targetObjectName;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == targetObjectName)
        {
            gameObject.SetActive(false);
            starNumber++;

         }

    }
}
