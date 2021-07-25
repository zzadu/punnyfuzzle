using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_Hide : MonoBehaviour
{
    public string targetObjectName;
    public static int stars = 0;
    public static int startStars = 0;


    void Start()
    {
        startStars = Score.firstHighestScore;
        stars = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == targetObjectName)
        {
            OnCollision_Hide.stars += 1;
            this.gameObject.SetActive(false);
        }
    }
}
