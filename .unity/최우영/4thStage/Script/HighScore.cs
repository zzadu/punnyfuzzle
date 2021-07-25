using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public string showObjectName1;
    public string showObjectName2;
    public string showObjectName3;
    public string showObjectName4;

    public GameObject showObject1;
    public GameObject showObject2;
    public GameObject showObject3;
    public GameObject showObject4;

    void Start()
    {
        showObject1 = GameObject.Find(showObjectName1);
        showObject2 = GameObject.Find(showObjectName2);
        showObject3 = GameObject.Find(showObjectName3);
        showObject4 = GameObject.Find(showObjectName4);

        showObject1.SetActive(false);
        showObject2.SetActive(false);
        showObject3.SetActive(false);
        showObject4.SetActive(false);

        Count_Show.highScore = Counter.value;

        if (Count_Show.highScore == 0)
        {
            showObject1.SetActive(true);
        }

        if (Count_Show.highScore == 1)
        {
            showObject2.SetActive(true);
        }

        if (Count_Show.highScore == 2)
        {
            showObject3.SetActive(true);
        }

        if (Count_Show.highScore == 3)
        {
            showObject4.SetActive(true);
        }

    }

}
