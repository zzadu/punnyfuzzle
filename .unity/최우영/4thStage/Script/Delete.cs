using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    public int Count;
    
    void Update()
    {
        if(Counter.value == Count)
        {
            this.gameObject.SetActive(false);
        }
        
    }
}
