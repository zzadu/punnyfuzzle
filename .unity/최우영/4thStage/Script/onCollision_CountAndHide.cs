using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision_CountAndHide : MonoBehaviour
{
    public string targetObjectName;
    public int addValue = 1;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == targetObjectName)
        {
            Counter.value = Counter.value + addValue;
            this.gameObject.SetActive(false);
        }
    }
}
