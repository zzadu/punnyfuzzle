using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ob_Move : MonoBehaviour
{
    Rigidbody2D rbody;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
}
