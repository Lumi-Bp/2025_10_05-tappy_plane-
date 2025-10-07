using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float cooldown = 3;
    private float lastSpawnTime;



    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastSpawnTime > cooldown)
        {
            lastSpawnTime = Time.time;
            Instantiate(obstaclePrefab); //position,rotation,parent
        }
    }
}
