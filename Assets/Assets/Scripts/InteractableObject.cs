using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableObject : MonoBehaviour
{
    private bool inTrigger;
    private void OnTriggerEnter2D(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("E ������");
            inTrigger = true;
        }
        
            
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // �� ��ȯ
        }
    }
}
