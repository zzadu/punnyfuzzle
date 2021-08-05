using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore_7 : MonoBehaviour
{
    GameObject one;
    GameObject two;
    GameObject three;

    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore7"))
        {
            HighScoreBoard_7.highestScore = PlayerPrefs.GetInt("HighScore7");
        }

        one = GameObject.Find("one star_7");
        two = GameObject.Find("two stars_7");
        three = GameObject.Find("three stars_7");

        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);

    }

    void Update()
    {
        if (HighScoreBoard_7.highestScore == 1)
        {
            one.SetActive(true);
        }
        if (HighScoreBoard_7.highestScore == 2)
        {
            two.SetActive(true);
        }
        if (HighScoreBoard_7.highestScore == 3)
        {
            three.SetActive(true);
        }
    }
}
