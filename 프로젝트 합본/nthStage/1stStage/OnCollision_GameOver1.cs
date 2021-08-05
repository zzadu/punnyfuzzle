using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_GameOver1 : MonoBehaviour
{
    public string targetObjectName;
    public string sceneName;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            HighScoreBoard_1.highestScore = OnCollision_Star1.beforeHighestStars;
            OnCollision_Star1.stars = 0;
            SceneManager.LoadScene(sceneName);
        }
    }
}
