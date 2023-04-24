using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    [SerializeField] private ObstacleMovement obstacleMovement;
    private AudioSource graveSliding;

    private void Start()
    {
        graveSliding = GetComponent<AudioSource>();
        graveSliding.Play();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            obstacleMovement.enabled = false;
            graveSliding.Stop();
            Debug.Log("Collision with " + collision.collider.name);
        }
    }
}