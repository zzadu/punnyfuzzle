using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class warning_yes : MonoBehaviour
{
    public string sceneName;

    void OnMouseDown()
    {
        SceneManager.LoadScene(sceneName);
    }
}
