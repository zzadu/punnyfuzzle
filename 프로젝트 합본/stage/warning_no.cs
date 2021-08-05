using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class warning_no : MonoBehaviour
{
    GameObject warning1;
    GameObject warning2;
    GameObject warning3;

    void Start()
    {
        warning1 = GameObject.Find("warning1");
        warning2 = GameObject.Find("warning2");
        warning3 = GameObject.Find("warning3");
    }

    void OnMouseDown()
    {
        warning1.SetActive(false);
        warning2.SetActive(false);
        warning3.SetActive(false);

        StagePrevious.stage.GetComponent<StageRotation>().enabled = true;
        StagePrevious.ob.GetComponent<Rigidbody2D>().simulated = true;
    }
}
