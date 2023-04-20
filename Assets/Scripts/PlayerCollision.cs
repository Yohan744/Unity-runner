using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovemement;
    private Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            playerMovemement.enabled = false;
            anim.Play("Dead00");
            Debug.Log("Collision with " + collision.collider.name);
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
