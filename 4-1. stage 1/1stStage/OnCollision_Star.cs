using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_Star : MonoBehaviour
{
    public static int stars = 0;
    public string targetObjectName;
    public static int beforeHighestStars = 0;

    void Start()
    {
        beforeHighestStars = HighScoreBoard.firstHighestScore;
        stars = 0;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            OnCollision_Star.stars += 1;
            this.gameObject.SetActive(false);
        }
    }
}
