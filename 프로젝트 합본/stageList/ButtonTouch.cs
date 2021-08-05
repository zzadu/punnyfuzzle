using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonTouch : MonoBehaviour
{
    public string sceneName;
    public void NextScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
