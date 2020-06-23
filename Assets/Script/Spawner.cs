using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Obstacles;
    public int nextSpawn = 1;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnObstacle()
    {
        int random = Random.Range(0, 4);
        Vector3 spawnpos = new Vector3(Random.Range(-2, 2), 0, 0);

        nextSpawn -= 1;

        if(nextSpawn <= 0)
        {
            Instantiate(Obstacles[random], spawnpos, Quaternion.identity);
            nextSpawn = 1;
        }
    }
}
