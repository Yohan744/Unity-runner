using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject obstaclePrefab;
    [Header("Timers")] [SerializeField] private float timeToSpawn = 2f;
    [SerializeField] private float timeBetweenWaves = 1f;

    void CreateObstacle()
    {
        int numberOfObstacleToRemove = Random.Range(1, 4);
        int[] obstacleArray = new int[spawnPoints.Length];

        for (int i = 0; i < obstacleArray.Length; i++)
        {
            obstacleArray[i] = 1;
        }

        for (int i = 0; i < numberOfObstacleToRemove; i++)
        {
            var indexToDelete = Random.Range(0, obstacleArray.Length);
            obstacleArray[indexToDelete] = 0;
        }

        for (int i = 0; i < obstacleArray.Length; i++)
        {
            if (obstacleArray[i] == 1)
            {
                Instantiate(obstaclePrefab, spawnPoints[i].position,
                    transform.rotation * Quaternion.Euler(0f, 180f, 0f));
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