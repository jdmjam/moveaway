using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject enemy1;

    private float spawnTimer = 2f;
    private float nextSpawn = 0f;

    
    private void Update()
    {
        if(Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnTimer; 
            GameObject enemy = Instantiate(enemy1, transform.position, transform.rotation);
        }
    }


}
