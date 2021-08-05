using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_Star7 : MonoBehaviour
{
    public static int stars = 0;
    public string targetObjectName;
    public static int beforeHighestStars = 0;
    public static bool score = false;

    void Start()
    {
        score = true;
        beforeHighestStars = HighScoreBoard_7.highestScore;
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
