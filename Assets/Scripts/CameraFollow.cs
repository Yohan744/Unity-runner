using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] private Transform player;

    [SerializeField] private Vector3 offset;
    [SerializeField] private Quaternion rotationOfCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
        transform.rotation = rotationOfCamera;
    }
}
