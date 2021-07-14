using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnMouseDown_MovePrevious : MonoBehaviour
{
    int sceneIndex;

    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void MovePrevious()
    {
        SceneManager.LoadScene(sceneIndex - 1);
    }
}
