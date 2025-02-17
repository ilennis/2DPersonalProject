using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float movespeed = 1f;
    private Vector2 inputVec; // πÊ«‚ ¿Œ«≤
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    private Animator anim;

    private void Awake()
    {        
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }    
    
    private void FixedUpdate()
    {
        Move();
    }
    private void LateUpdate()
    {
        anim.SetFloat("Speed", inputVec.magnitude);
        if (inputVec.x != 0)
        {
            sr.flipX = inputVec.x < 0;
        }
    }
    
    private void Move()
    {
        Vector2 nextVec = inputVec * movespeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + nextVec);
    }
    private void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }
}
