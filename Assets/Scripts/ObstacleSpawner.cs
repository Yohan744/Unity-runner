using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{

    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject obstaclePrefab;
    [Header("Timers")]
    [SerializeField] private float timeToSpawn = 2f;
    [SerializeField] private float timeBetweenWaves = 1f;

    void CreateObstacle()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(obstaclePrefab, spawnPoints[i].position, transform.rotation * Quaternion.Euler (0f, 180f, 0f));
            }
        }
    }

    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            CreateObstacle();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }

}
