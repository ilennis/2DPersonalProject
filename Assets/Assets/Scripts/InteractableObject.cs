using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableObject : MonoBehaviour
{
    [SerializeField] private bool inTrigger;
    [SerializeField] private GameObject gameObject;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("E 누르기");
            inTrigger = true;
            gameObject.SetActive(true);
        }
        
            
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
            gameObject.SetActive(false);
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // 씬 전환
            if(inTrigger)
                SceneManager.LoadScene("SampleScene");
        }
    }
}
