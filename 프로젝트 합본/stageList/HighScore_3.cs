using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore_3 : MonoBehaviour
{
    GameObject one;
    GameObject two;
    GameObject three;

    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore3"))
        {
            HighScoreBoard_3.highestScore = PlayerPrefs.GetInt("HighScore3");
        }

        one = GameObject.Find("one star_3");
        two = GameObject.Find("two stars_3");
        three = GameObject.Find("three stars_3");

        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);

    }

    void Update()
    {
        if (HighScoreBoard_3.highestScore == 1)
        {
            one.SetActive(true);
        }
        if (HighScoreBoard_3.highestScore == 2)
        {
            two.SetActive(true);
        }
        if (HighScoreBoard_3.highestScore == 3)
        {
            three.SetActive(true);
        }
    }
}
