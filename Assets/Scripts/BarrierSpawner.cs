using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawner : Spawner
{
    private void Start()
    {
        _halfHeight = _objectToSpawn.GetComponent<BoxCollider2D>().size.y / 2;
        _spawnTimer = _minSpawnTime;
    }

    private void Update()
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            Instantiate(_objectToSpawn, new Vector2(transform.position.x, Random.Range(transform.position.y - _halfHeight, transform.position.y)), Quaternion.identity);
            _spawnTimer = Random.Range(_minSpawnTime, _maxSpawnTime); 
        }
    }
}
