using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore_1 : MonoBehaviour
{
    GameObject one;
    GameObject two;
    GameObject three;

    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore1"))
        {
            HighScoreBoard_1.highestScore = PlayerPrefs.GetInt("HighScore1");
        }

        one = GameObject.Find("one star_1");
        two = GameObject.Find("two stars_1");
        three = GameObject.Find("three stars_1");

        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);

    }

    void Update()
    {
        if (HighScoreBoard_1.highestScore == 1)
        {
            one.SetActive(true);
        }
        if (HighScoreBoard_1.highestScore == 2)
        {
            two.SetActive(true);
        }
        if (HighScoreBoard_1.highestScore == 3)
        {
            three.SetActive(true);
        }

    }
}
