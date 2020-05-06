using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRespawnPoint : MonoBehaviour
{
    [SerializeField] public GameObject _enemy;
    [SerializeField] public float SpawnRate = 2f;
    public float _nextSpawn = 0.0f;
    
    public void Update()
    {
        if (Time.time > +_nextSpawn)
        {
            _nextSpawn = Time.time + SpawnRate;
            Instantiate(_enemy, transform.position, transform.rotation);
        }
    }
}
