using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieManager : MonoBehaviour {

    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private GameObject[] enemiesToSpawn;
    [SerializeField] private float spawnTimer = 2f;

    private void Start()    {
        InvokeRepeating("Spawn",spawnTimer,spawnTimer);
    }

    public void Spawn()    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);       
        GameObject enemy = Instantiate(enemiesToSpawn[0], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
        
    }

}
