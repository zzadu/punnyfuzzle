using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reset : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene(OnMouseDown_MovePrevious.replayScene);
    }
}
