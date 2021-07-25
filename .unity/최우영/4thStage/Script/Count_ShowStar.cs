using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count_ShowStar : MonoBehaviour
{
    public int Count;
    public string showObjectName;
    public string targetObjectName;

    void Start()
    {
        GameObject.Find(showObjectName).gameObject.SetActive(false);
    }

    void Update()
    {
        if (Counter.value == Count)
        {
            GameObject.Find("starScore").transform.Find(showObjectName).gameObject.SetActive(true);
            GameObject.Find(targetObjectName).gameObject.SetActive(false);
        }
    }
}
