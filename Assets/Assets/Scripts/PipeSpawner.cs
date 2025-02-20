using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    
    [SerializeField] private float heightRange = 2.5f;
    [SerializeField] private GameObject spawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Edge"))
        {
            Debug.Log("Entered");
            collision.transform.parent.position = spawnPoint.transform.position;
        }
    }
}
