using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnMouseDown_MovePrevious : MonoBehaviour
{
    public static string replayScene;

    public void OnMouseDown()
    {
        SceneManager.LoadScene(replayScene);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(replayScene);
        }
    }
}
