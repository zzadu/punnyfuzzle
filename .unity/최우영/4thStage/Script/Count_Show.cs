using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count_Show : MonoBehaviour
{
    public int Count1;
    public int Count2;
    public int Count3;

    public string showObjectName1;
    public string showObjectName2;
    public string showObjectName3;
   
    public string targetObjectName1;
    public string targetObjectName2;

    public GameObject showObject1;
    public GameObject showObject2;
    public GameObject showObject3;

    public static int highScore = 0;

    void Start()
    {
        showObject1 = GameObject.Find(showObjectName1);
        showObject2 = GameObject.Find(showObjectName2);
        showObject3 = GameObject.Find(showObjectName3);

        showObject1.SetActive(false);
        showObject2.SetActive(false);
        showObject3.SetActive(false);
    }

    void Update()
    {
        if (Counter.value == Count1)
        {
            showObject1.SetActive(true);
            highScore = Count1;
        }

        if (Counter.value == Count2)
        {
            showObject2.SetActive(true);
            GameObject.Find(targetObjectName1).gameObject.SetActive(false);
            highScore = Count2;
        }

        if (Counter.value == Count3)
        {
            showObject3.SetActive(true);
            GameObject.Find(targetObjectName2).gameObject.SetActive(false);
            highScore = Count3;
        }
    }
}

