using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : Spawner
{
    private void Start()
    {
        _halfHeight = GetComponent<BoxCollider2D>().size.y / 2;
        _spawnTimer = _minSpawnTime*2;
    }

    private void Update() 
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            float positionY = Random.Range(transform.position.y - _halfHeight, transform.position.y + _halfHeight);
            for (int i = 0; i < Random.Range(1, 6); i++)
            {
                Instantiate(_objectToSpawn, new Vector2(transform.position.x + i, positionY), Quaternion.identity);
            }
            _spawnTimer = Random.Range(_minSpawnTime, _maxSpawnTime);
        }     
    }
}
