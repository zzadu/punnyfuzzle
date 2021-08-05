using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore_4 : MonoBehaviour
{
    GameObject one;
    GameObject two;
    GameObject three;

    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore4"))
        {
            HighScoreBoard_4.highestScore = PlayerPrefs.GetInt("HighScore4");
        }

        one = GameObject.Find("one star_4");
        two = GameObject.Find("two stars_4");
        three = GameObject.Find("three stars_4");

        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);

    }

    void Update()
    {
        if (HighScoreBoard_4.highestScore == 1)
        {
            one.SetActive(true);
        }
        if (HighScoreBoard_4.highestScore == 2)
        {
            two.SetActive(true);
        }
        if (HighScoreBoard_4.highestScore == 3)
        {
            three.SetActive(true);
        }
    }
}
