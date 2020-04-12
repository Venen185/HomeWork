﻿using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyRespawnPoint : MonoBehaviour
{
    public GameObject enemy;
    public float spawnRate = 2f;
    float randX;
    Vector2 whereToSpawn;
    float nextSpawn = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
         if (Time.time > + nextSpawn)
        {
          nextSpawn = Time.time + spawnRate;
          randX = Random.Range(-5,0);
          whereToSpawn = new Vector2 (randX, transform.position.y);
          Instantiate (enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
