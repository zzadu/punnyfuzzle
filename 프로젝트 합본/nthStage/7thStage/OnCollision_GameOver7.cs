using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_GameOver7 : MonoBehaviour
{
    public string targetObjectName;
    public string sceneName;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            HighScoreBoard_7.highestScore = OnCollision_Star7.beforeHighestStars;
            OnCollision_Star7.stars = 0;
            SceneManager.LoadScene(sceneName);
        }
    }
}
