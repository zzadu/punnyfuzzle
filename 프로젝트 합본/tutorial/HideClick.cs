using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideClick : MonoBehaviour
{
    GameObject click;
    void Start()
    {
        click = GameObject.Find("click");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            click.SetActive(false);
        }
    }
}
