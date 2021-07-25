using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision_StopGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name=="barrier")
        {
            Time.timeScale = 0;
        }
    }
}
