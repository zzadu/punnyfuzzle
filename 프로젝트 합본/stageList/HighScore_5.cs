using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore_5 : MonoBehaviour
{
    GameObject one;
    GameObject two;
    GameObject three;

    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore5"))
        {
            HighScoreBoard_5.highestScore = PlayerPrefs.GetInt("HighScore5");
        }

        one = GameObject.Find("one star_5");
        two = GameObject.Find("two stars_5");
        three = GameObject.Find("three stars_5");

        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);

    }

    void Update()
    {
        if (HighScoreBoard_5.highestScore == 1)
        {
            one.SetActive(true);
        }
        if (HighScoreBoard_5.highestScore == 2)
        {
            two.SetActive(true);
        }
        if (HighScoreBoard_5.highestScore == 3)
        {
            three.SetActive(true);
        }
    }
}
