using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore_6 : MonoBehaviour
{
    GameObject one;
    GameObject two;
    GameObject three;

    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore6"))
        {
            HighScoreBoard_6.highestScore = PlayerPrefs.GetInt("HighScore6");
        }

        one = GameObject.Find("one star_6");
        two = GameObject.Find("two stars_6");
        three = GameObject.Find("three stars_6");

        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);

    }

    void Update()
    {
        if (HighScoreBoard_6.highestScore == 1)
        {
            one.SetActive(true);
        }
        if (HighScoreBoard_6.highestScore == 2)
        {
            two.SetActive(true);
        }
        if (HighScoreBoard_6.highestScore == 3)
        {
            three.SetActive(true);
        }
    }
}
