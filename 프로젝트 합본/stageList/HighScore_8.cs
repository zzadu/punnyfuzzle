using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore_8 : MonoBehaviour
{
    GameObject one;
    GameObject two;
    GameObject three;

    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore8"))
        {
            HighScoreBoard_8.highestScore = PlayerPrefs.GetInt("HighScore8");
        }

        one = GameObject.Find("one star_8");
        two = GameObject.Find("two stars_8");
        three = GameObject.Find("three stars_8");

        one.SetActive(false);
        two.SetActive(false);
        three.SetActive(false);

    }

    void Update()
    {
        if (HighScoreBoard_8.highestScore == 1)
        {
            one.SetActive(true);
        }
        if (HighScoreBoard_8.highestScore == 2)
        {
            two.SetActive(true);
        }
        if (HighScoreBoard_8.highestScore == 3)
        {
            three.SetActive(true);
        }
    }
}
