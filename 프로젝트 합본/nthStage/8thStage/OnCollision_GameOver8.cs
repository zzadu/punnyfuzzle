using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_GameOver8 : MonoBehaviour
{
    public string targetObjectName;
    public string sceneName;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            HighScoreBoard_8.highestScore = OnCollision_Star8.beforeHighestStars;
            OnCollision_Star8.stars = 0;
            SceneManager.LoadScene(sceneName);
        }
    }
}
