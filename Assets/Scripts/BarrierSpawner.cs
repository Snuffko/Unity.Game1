using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawner : Spawner
{
    override public void Start()
    {
        _halfHeight = _objectToSpawn.GetComponent<BoxCollider2D>().size.y / 2;
        _spawnTimer = _minSpawnTime;
    }

    override public void Update()
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            Spawn(transform.position.x, Random.Range(transform.position.y - _halfHeight, transform.position.y));
            _spawnTimer = Random.Range(_minSpawnTime, _maxSpawnTime);
        }
    }
}
