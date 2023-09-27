using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float xRange = 10.0f;
    [SerializeField] private InputActionReference feed;

    private Vector2 move;
    private Rigidbody2D rb;
    public GameObject projectilePrefab;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnMove(InputValue value) {
        move = value.Get<Vector2>();
    }

    private void FixedUpdate()
    {
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
       
        //if(move.x != 0 || move.y != 0)
        //{
        //    rb.velocity = move * speed;
        //}

        //rb.AddForce(move * speed);
    }
}