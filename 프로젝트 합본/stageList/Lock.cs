using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lock : MonoBehaviour
{
    GameObject lock2;
    GameObject lock3;
    GameObject lock4;
    GameObject lock5;
    GameObject lock6;
    GameObject lock7;
    GameObject lock8;

    GameObject stage2;
    GameObject stage3;
    GameObject stage4;
    GameObject stage5;
    GameObject stage6;
    GameObject stage7;
    GameObject stage8;

    void Start()
    {
        lock2 = GameObject.Find("lock_2");
        lock3 = GameObject.Find("lock_3");
        lock4 = GameObject.Find("lock_4");
        lock5 = GameObject.Find("lock_5");
        lock6 = GameObject.Find("lock_6");
        lock7 = GameObject.Find("lock_7");
        lock8 = GameObject.Find("lock_8");

        stage2 = GameObject.Find("stage2");
        stage3 = GameObject.Find("stage3");
        stage4 = GameObject.Find("stage4");
        stage5 = GameObject.Find("stage5");
        stage6 = GameObject.Find("stage6");
        stage7 = GameObject.Find("stage7");
        stage8 = GameObject.Find("stage8");

        stage2.GetComponent<Button>().enabled = false;
        stage3.GetComponent<Button>().enabled = false;
        stage4.GetComponent<Button>().enabled = false;
        stage5.GetComponent<Button>().enabled = false;
        stage6.GetComponent<Button>().enabled = false;
        stage7.GetComponent<Button>().enabled = false;
        stage8.GetComponent<Button>().enabled = false;
        
    }

    void Update()
    {
        if (PlayerPrefs.HasKey("HighScore1") || HighScoreBoard_1.highestScore >= 1)
        {
            lock2.SetActive(false);
            stage2.GetComponent<Button>().enabled = true;
        }
         if (PlayerPrefs.GetInt("HighScore2") >= 1 || HighScoreBoard_2.highestScore >= 1)
        {
            lock3.SetActive(false);
            stage3.GetComponent<Button>().enabled = true;
        }
         if (PlayerPrefs.GetInt("HighScore3") >= 1 || HighScoreBoard_3.highestScore >= 1)
        {
            lock4.SetActive(false);
            stage4.GetComponent<Button>().enabled = true;
        }
         if (PlayerPrefs.GetInt("HighScore4") >= 1 || HighScoreBoard_4.highestScore >= 1)
        {
            lock5.SetActive(false);
            stage5.GetComponent<Button>().enabled = true;
        }
         if (PlayerPrefs.GetInt("HighScore5") >= 1 || HighScoreBoard_5.highestScore >= 1)
        {
            lock6.SetActive(false);
            stage6.GetComponent<Button>().enabled = true;
        }
         if (PlayerPrefs.GetInt("HighScore6") >= 1 || HighScoreBoard_6.highestScore >= 1)
        {
            lock7.SetActive(false);
            stage7.GetComponent<Button>().enabled = true;
        }
         if (PlayerPrefs.GetInt("HighScore7") >= 1 || HighScoreBoard_7.highestScore >= 1)
        {
            lock8.SetActive(false);
            stage8.GetComponent<Button>().enabled = true;
        }


    }
}
