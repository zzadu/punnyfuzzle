using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreBoard_3 : MonoBehaviour
{
    public static int highestScore = 0;

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

        if (highestScore == 0)
        {
            zeroObject.SetActive(true);
            oneObject.SetActive(false);
            twoObject.SetActive(false);
            threeObject.SetActive(false);
        }
        if (highestScore == 1)
        {
            zeroObject.SetActive(false);
            oneObject.SetActive(true);
            twoObject.SetActive(false);
            threeObject.SetActive(false);
        }
        if (highestScore == 2)
        {
            zeroObject.SetActive(false);
            oneObject.SetActive(false);
            twoObject.SetActive(true);
            threeObject.SetActive(false);
        }
        if (highestScore == 3)
        {
            zeroObject.SetActive(false);
            oneObject.SetActive(false);
            twoObject.SetActive(false);
            threeObject.SetActive(true);
        }
    }
}
