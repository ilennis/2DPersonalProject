using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePipes : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;   
    }
}
