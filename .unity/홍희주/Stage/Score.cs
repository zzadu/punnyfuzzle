using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int firstHighestScore = 0;

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
        oneObject = GameObject.Find(showObjectName0);
        twoObject = GameObject.Find(showObjectName0);
        threeObject = GameObject.Find(showObjectName0);


        if (firstHighestScore == 0)
        {
            zeroObject.SetActive(true);
            oneObject.SetActive(false);
            twoObject.SetActive(false);
            threeObject.SetActive(false);
        }

        if (firstHighestScore == 1)
        {
            zeroObject.SetActive(false);
            oneObject.SetActive(true);
            twoObject.SetActive(false);
            threeObject.SetActive(false);
        }

        if (firstHighestScore == 2)
        {
            zeroObject.SetActive(false);
            oneObject.SetActive(false);
            twoObject.SetActive(true);
            threeObject.SetActive(false);
        }

        if (firstHighestScore == 3)
        {
            zeroObject.SetActive(false);
            oneObject.SetActive(false);
            twoObject.SetActive(false);
            threeObject.SetActive(true);
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (OnCollision_Hide.stars > firstHighestScore)
        {
            firstHighestScore = OnCollision_Hide.stars;
        }
    }
}
