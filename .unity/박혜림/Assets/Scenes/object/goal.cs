using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goal : MonoBehaviour
{
    public string targetObjectName;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == targetObjectName)
        {
            gameObject.SetActive(false);//�׽�Ʈ��,���� ����
            //SceneManager.LoadScene(/*���� Ŭ���� ȭ��*/);

        }

    }
}

