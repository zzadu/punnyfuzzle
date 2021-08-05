using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoardT : MonoBehaviour
{
    public string showObjectName0 = "";
    public string showObjectName1 = "";
    public string showObjectName2 = "";
    public string showObjectName3 = "";

    GameObject zeroObject;
    GameObject oneObject;
    GameObject twoObject;
    GameObject threeObject;

    void Start()
    {
        PlayerPrefs.SetInt("goTutorial", 0);
        zeroObject = GameObject.Find(showObjectName0);
        oneObject = GameObject.Find(showObjectName1);
        twoObject = GameObject.Find(showObjectName2);
        threeObject = GameObject.Find(showObjectName3);
    }

    void Update()
    {
        if (OnCollision_StarT.stars == 0)
        {
            oneObject.SetActive(false);
            twoObject.SetActive(false);
            threeObject.SetActive(false);
            zeroObject.SetActive(true);
        }
        if (OnCollision_StarT.stars == 1)
        {
            zeroObject.SetActive(false);
            twoObject.SetActive(false);
            threeObject.SetActive(false);
            oneObject.SetActive(true);
        }
        if (OnCollision_StarT.stars == 2)
        {
            zeroObject.SetActive(false);
            oneObject.SetActive(false);
            threeObject.SetActive(false);
            twoObject.SetActive(true);
        }
        if (OnCollision_StarT.stars == 3)
        {
            zeroObject.SetActive(false);
            oneObject.SetActive(false);
            twoObject.SetActive(false);
            threeObject.SetActive(true);
        }
    }
}
