using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ob : MonoBehaviour
{

    Rigidbody2D rbody;

    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        rbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }
}
