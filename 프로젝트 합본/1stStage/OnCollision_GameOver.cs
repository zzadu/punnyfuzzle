using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_GameOver : MonoBehaviour
{
    public string targetObjectName;
    public string sceneName;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            HighScoreBoard.firstHighestScore = OnCollision_Star.beforeHighestStars;
            OnCollision_Star.stars = 0;
            SceneManager.LoadScene(sceneName);
        }
    }
}
