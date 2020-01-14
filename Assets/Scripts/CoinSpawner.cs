using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : Spawner
{
    override public void SetHalfHeight() {
        _halfHeight = GetComponent<BoxCollider2D>().size.y / 2;
    }

    override public void TrySpawn() 
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {        
            float positionY = Random.Range(transform.position.y - _halfHeight, transform.position.y + _halfHeight);
            for (int i = 0; i < Random.Range(1, 6); i++)
            {
                Spawn(transform.position.x + i, positionY);
            }
            _spawnTimer = Random.Range(_minSpawnTime, _maxSpawnTime);
        }
    }
} 