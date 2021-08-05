using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnCollision_Score : MonoBehaviour
{
    public string targetObjectName;
    public string sceneName;

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == targetObjectName)
        {
            if (SceneManager.GetActiveScene().name == "1stStage")
            {
                ChangeStar.clear1 = true;

                if (OnCollision_Star1.stars > HighScoreBoard_1.highestScore)
                {
                    HighScoreBoard_1.highestScore = OnCollision_Star1.stars;
                }
            }
            else if (SceneManager.GetActiveScene().name == "2ndStage")
            {
                ChangeStar.clear2 = true;

                if (OnCollision_Star2.stars > HighScoreBoard_2.highestScore)
                {
                    HighScoreBoard_2.highestScore = OnCollision_Star2.stars;
                }
            }
            else if (SceneManager.GetActiveScene().name == "3rdStage")
            {
                ChangeStar.clear3 = true;

                if (OnCollision_Star3.stars > HighScoreBoard_3.highestScore)
                {
                    HighScoreBoard_3.highestScore = OnCollision_Star3.stars;
                }
            }
            else if (SceneManager.GetActiveScene().name == "4thStage")
            {
                ChangeStar.clear4 = true;

                if (OnCollision_Star4.stars > HighScoreBoard_4.highestScore)
                {
                    HighScoreBoard_4.highestScore = OnCollision_Star4.stars;
                }

            }
            else if (SceneManager.GetActiveScene().name == "5thStage")
            {
                ChangeStar.clear5 = true;

                if (OnCollision_Star5.stars > HighScoreBoard_5.highestScore)
                {
                    HighScoreBoard_5.highestScore = OnCollision_Star5.stars;
                }

            }
            else if (SceneManager.GetActiveScene().name == "6thStage")
            {
                ChangeStar.clear6 = true;

                if (OnCollision_Star6.stars > HighScoreBoard_6.highestScore)
                {
                    HighScoreBoard_6.highestScore = OnCollision_Star6.stars;
                }

            }
            else if (SceneManager.GetActiveScene().name == "7thStage")
            {
                ChangeStar.clear7 = true;

                if (OnCollision_Star7.stars > HighScoreBoard_7.highestScore)
                {
                    HighScoreBoard_7.highestScore = OnCollision_Star7.stars;
                }

            }
            else if (SceneManager.GetActiveScene().name == "8thStage")
            {
                ChangeStar.clear8 = true;

                if (OnCollision_Star8.stars > HighScoreBoard_8.highestScore)
                {
                    HighScoreBoard_8.highestScore = OnCollision_Star8.stars;
                }

            }

            SceneManager.LoadScene(sceneName);
        }
    }
}
