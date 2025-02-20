using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject wallPrefab;
    [SerializeField] private float spawnRate = 2f;
    [SerializeField] private float heightRange = 2.5f;
    [SerializeField] public  GameObject spawnPoint;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnWall), 1f, spawnRate);
    }

    void SpawnWall()
    {
        float randomY = Random.Range(-heightRange, heightRange);
        Vector2 spawnPosition = new Vector2(spawnPoint.transform.position.x, randomY);

        GameObject newWall = Instantiate(wallPrefab, spawnPosition, Quaternion.identity);
    }
}
