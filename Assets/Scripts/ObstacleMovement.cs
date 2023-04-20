using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float forwardForce = 500f;
    [SerializeField] private Rigidbody rb;

    void FixedUpdate()
    {
        Debug.Log("Force : " + (forwardForce + (Time.timeSinceLevelLoad * 13)) * Time.deltaTime);
        rb.AddForce(new Vector3(0, 0, -(forwardForce + (Time.timeSinceLevelLoad * 13))* Time.deltaTime));

    }
}