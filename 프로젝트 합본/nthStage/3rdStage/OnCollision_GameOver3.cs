using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_GameOver3 : MonoBehaviour
{
    public string targetObjectName;
    public string sceneName;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            HighScoreBoard_3.highestScore = OnCollision_Star3.beforeHighestStars;
            OnCollision_Star3.stars = 0;
            SceneManager.LoadScene(sceneName);
        }
    }
}
