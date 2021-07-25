using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    GameObject lock2;
    GameObject lock3;
    GameObject lock4;

    GameObject stage2;
    GameObject stage3;
    GameObject stage4;

    void Start()
    {
        lock2 = GameObject.Find("lock_2");
        lock3 = GameObject.Find("lock_3");
        lock4 = GameObject.Find("lock_4");

        stage2 = GameObject.Find("stage2");
        stage3 = GameObject.Find("stage3");
        stage4 = GameObject.Find("stage4");

        stage2.GetComponent<BoxCollider2D>().enabled = false;
        stage3.GetComponent<BoxCollider2D>().enabled = false;
        stage4.GetComponent<BoxCollider2D>().enabled = false;
        
    }

    void Update()
    {
        if (HighScoreBoard.firstHighestScore == 3)
        {
            lock2.SetActive(false);
            stage2.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
