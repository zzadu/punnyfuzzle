using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class esc : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (SceneManager.GetActiveScene().name == "Entrance")
            {
                Application.Quit();
            }
            else if (SceneManager.GetActiveScene().name == "tutorial" || SceneManager.GetActiveScene().name == "stageList")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
            if (SceneManager.GetActiveScene().name == "tutorialScore" || SceneManager.GetActiveScene().name == "help")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
            }
            if (SceneManager.GetActiveScene().name == "start")
            {
                SceneManager.LoadScene("Entrance");
            }
            if (SceneManager.GetActiveScene().name == "1stStage" || SceneManager.GetActiveScene().name == "2ndStage" ||
                SceneManager.GetActiveScene().name == "3rdStage" || SceneManager.GetActiveScene().name == "4thStage" ||
                SceneManager.GetActiveScene().name == "5thStage" || SceneManager.GetActiveScene().name == "6thStage" ||
                SceneManager.GetActiveScene().name == "7thStage" || SceneManager.GetActiveScene().name == "8thStage")
            {
                SceneManager.LoadScene("stageList");
            }

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
