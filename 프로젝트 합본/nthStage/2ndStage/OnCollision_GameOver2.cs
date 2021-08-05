using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_GameOver2 : MonoBehaviour
{
    public string targetObjectName;
    public string sceneName;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            HighScoreBoard_2.highestScore = OnCollision_Star2.beforeHighestStars;
            OnCollision_Star2.stars = 0;
            SceneManager.LoadScene(sceneName);
        }
    }
}
