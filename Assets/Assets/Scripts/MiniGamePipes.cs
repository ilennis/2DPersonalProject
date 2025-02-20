using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGamePipes : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
   

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;  

        if(transform.position.x < -12f)
        {
            Destroy(gameObject);
        }
    }
   
}
