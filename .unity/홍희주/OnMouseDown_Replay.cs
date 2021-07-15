using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnMouseDown_Replay : MonoBehaviour
{
    void OnMouseDown()
    {
        SceneManager.LoadScene(scenename);
    }
}