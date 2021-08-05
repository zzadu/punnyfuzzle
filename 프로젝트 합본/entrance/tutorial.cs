using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tutorial : MonoBehaviour
{
    public static int goTutorial = 1;

    void Start()
    {
        if (PlayerPrefs.HasKey("goTutorial") == false)
        {
            PlayerPrefs.SetInt("goTutorial", goTutorial);
        }
    }


    public void OnMouseDown()
    {
        if (PlayerPrefs.GetInt("goTutorial") == 1)
        {
            SceneManager.LoadScene("tutorial");
        }
        else
        {
            SceneManager.LoadScene("start");
        }
    }
}