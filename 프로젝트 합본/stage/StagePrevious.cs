using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StagePrevious : MonoBehaviour
{
    GameObject warning1;
    GameObject warning2;
    GameObject warning3;

    public static GameObject stage;
    public static GameObject ob;

    void Start()
    {
        warning1 = GameObject.Find("warning1");
        warning2 = GameObject.Find("warning2");
        warning3 = GameObject.Find("warning3");

        warning1.SetActive(false);
        warning2.SetActive(false);
        warning3.SetActive(false);

        stage = GameObject.Find("stage");
        ob = GameObject.Find("ob");
    }

    public void OnMouseDown()
    {
        warning1.SetActive(true);
        warning2.SetActive(true);
        warning3.SetActive(true);

        stage.GetComponent<StageRotation>().enabled = false;
        ob.GetComponent<Rigidbody2D>().simulated = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            warning1.SetActive(true);
            warning2.SetActive(true);
            warning3.SetActive(true);

            stage.GetComponent<StageRotation>().enabled = false;
            ob.GetComponent<Rigidbody2D>().simulated = false;
        }
    }

    bool isPaused = false;
    void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            isPaused = true;
            Time.timeScale = 0;
        }
        else
        {
            if (isPaused)
            {
                isPaused = false;
                Time.timeScale = 1;
            }
        }
    }
}
