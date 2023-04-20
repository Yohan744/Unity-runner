using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private Rigidbody rb;
    [SerializeField] private float sideWayForce = 80f;
    private Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

   void FixedUpdate()
    {
        
        anim.Play("Run00");

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(sideWayForce * Time.deltaTime, 0, 0), ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            rb.AddForce(new Vector3(-sideWayForce * Time.deltaTime, 0, 0), ForceMode.VelocityChange);
        }

        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
        
    }
}
