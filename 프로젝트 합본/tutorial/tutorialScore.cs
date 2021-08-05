using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialScore : MonoBehaviour
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
        zeroObject = GameObject.Find(showObjectName0);
        oneObject = GameObject.Find(showObjectName1);
        twoObject = GameObject.Find(showObjectName2);
        threeObject = GameObject.Find(showObjectName3);

        if (OnCollision_StarT.stars == 0)
        {
            zeroObject.SetActive(true);
            oneObject.SetActive(false);
            twoObject.SetActive(false);
            threeObject.SetActive(false);
        }
        if (OnCollision_StarT.stars == 1)
        {
            zeroObject.SetActive(false);
            oneObject.SetActive(true);
            twoObject.SetActive(false);
            threeObject.SetActive(false);
        }
        if (OnCollision_StarT.stars == 2)
        {
            zeroObject.SetActive(false);
            oneObject.SetActive(false);
            twoObject.SetActive(true);
            threeObject.SetActive(false);
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
