using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour

{
    public GameObject wallPrefab;
    public GameObject spawnedWall;
   
    // Start is called before the first frame update
    void Start()
    {
        SpawnWall();
    }

    // Destroy and Remake the wall
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SpawnWall();
        }

    }
    //Spawns Wall in random place

    void SpawnWall()
    {
        //Destroy previous wall
        Destroy(spawnedWall);
        spawnedWall = Instantiate(wallPrefab);
        float randomX = Random.Range(40f, -1.8f);
        spawnedWall.transform.position = new Vector3(randomX, spawnedWall.transform.position.y, spawnedWall.transform.position.z);
    }
}

