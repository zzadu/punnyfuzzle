using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_GameOver6 : MonoBehaviour
{
    public string targetObjectName;
    public string sceneName;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            HighScoreBoard_6.highestScore = OnCollision_Star6.beforeHighestStars;
            OnCollision_Star6.stars = 0;
            SceneManager.LoadScene(sceneName);
        }
    }
}
