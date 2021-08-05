using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeStar : MonoBehaviour
{
    public string showObjectName0 = "";
    public string showObjectName1 = "";
    public string showObjectName2 = "";
    public string showObjectName3 = "";


    GameObject zeroObject;
    GameObject oneObject;
    GameObject twoObject;
    GameObject threeObject;

    public static bool clear1 = false;
    public static bool clear2 = false;
    public static bool clear3 = false;
    public static bool clear4 = false;
    public static bool clear5 = false;
    public static bool clear6 = false;
    public static bool clear7 = false;
    public static bool clear8 = false;

    void Start()
    {
        zeroObject = GameObject.Find(showObjectName0);
        oneObject = GameObject.Find(showObjectName1);
        twoObject = GameObject.Find(showObjectName2);
        threeObject = GameObject.Find(showObjectName3);

        // stage 1
        if (OnCollision_Star1.score)
        {
            if (OnCollision_Star1.stars == 0)
            {
                zeroObject.SetActive(true);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star1.stars == 1)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(true);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star1.stars == 2)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(true);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star1.stars == 3)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(true);
            }

            OnCollision_Star1.score = false;
            clear1 = true;

            PlayerPrefs.SetInt("HighScore1", HighScoreBoard_1.highestScore);
        }

        // stage 2
        else if (OnCollision_Star2.score)
        {
            if (OnCollision_Star2.stars == 0)
            {
                zeroObject.SetActive(true);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star2.stars == 1)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(true);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star2.stars == 2)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(true);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star2.stars == 3)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(true);
            }

            OnCollision_Star2.score = false;
            clear2 = true;

            PlayerPrefs.SetInt("HighScore2", HighScoreBoard_2.highestScore);
        }

        // stage 3
        else if (OnCollision_Star3.score)
        {
            if (OnCollision_Star3.stars == 0)
            {
                zeroObject.SetActive(true);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star3.stars == 1)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(true);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star3.stars == 2)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(true);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star3.stars == 3)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(true);
            }

            OnCollision_Star3.score = false;
            clear3 = true;

            PlayerPrefs.SetInt("HighScore3", HighScoreBoard_3.highestScore);
        }
        // stage 4
        else if (OnCollision_Star4.score)
        {
            if (OnCollision_Star4.stars == 0)
            {
                zeroObject.SetActive(true);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star4.stars == 1)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(true);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star4.stars == 2)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(true);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star4.stars == 3)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(true);
            }

            OnCollision_Star4.score = false;
            clear4 = true;

            PlayerPrefs.SetInt("HighScore4", HighScoreBoard_4.highestScore);
        }

        // stage 5
        else if (OnCollision_Star5.score)
        {
            if (OnCollision_Star5.stars == 0)
            {
                zeroObject.SetActive(true);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star5.stars == 1)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(true);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star5.stars == 2)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(true);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star5.stars == 3)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(true);
            }

            OnCollision_Star5.score = false;
            clear5 = true;

            PlayerPrefs.SetInt("HighScore5", HighScoreBoard_5.highestScore);
        }

        // stage 6
        else if (OnCollision_Star6.score)
        {
            if (OnCollision_Star6.stars == 0)
            {
                zeroObject.SetActive(true);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star6.stars == 1)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(true);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star6.stars == 2)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(true);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star6.stars == 3)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(true);
            }

            OnCollision_Star6.score = false;
            clear6 = true;

            PlayerPrefs.SetInt("HighScore6", HighScoreBoard_6.highestScore);
        }

        // stage 7
        else if (OnCollision_Star7.score)
        {
            if (OnCollision_Star7.stars == 0)
            {
                zeroObject.SetActive(true);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star7.stars == 1)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(true);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star7.stars == 2)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(true);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star7.stars == 3)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(true);
            }

            OnCollision_Star7.score = false;
            clear7 = true;

            PlayerPrefs.SetInt("HighScore7", HighScoreBoard_7.highestScore);
        }

        // stage 8
        else if (OnCollision_Star8.score)
        {
            if (OnCollision_Star8.stars == 0)
            {
                zeroObject.SetActive(true);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star8.stars == 1)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(true);
                twoObject.SetActive(false);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star8.stars == 2)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(true);
                threeObject.SetActive(false);
            }
            if (OnCollision_Star8.stars == 3)
            {
                zeroObject.SetActive(false);
                oneObject.SetActive(false);
                twoObject.SetActive(false);
                threeObject.SetActive(true);
            }

            OnCollision_Star8.score = false;
            clear8 = true;

            PlayerPrefs.SetInt("HighScore8", HighScoreBoard_8.highestScore);
        }
    }
}
