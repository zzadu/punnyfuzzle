using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_GameOver4 : MonoBehaviour
{
    public string targetObjectName;
    public string sceneName;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            HighScoreBoard_4.highestScore = OnCollision_Star4.beforeHighestStars;
            OnCollision_Star4.stars = 0;
            SceneManager.LoadScene(sceneName);
        }
    }
}
