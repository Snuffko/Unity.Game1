using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawner : Spawner
{
    override public void SetHalfHeight() {
        _halfHeight = _objectToSpawn.GetComponent<BoxCollider2D>().size.y / 2;
    }

    override public void TrySpawn() 
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            float positionY = Random.Range(transform.position.y - _halfHeight, transform.position.y);
            Spawn(transform.position.x, positionY);
            _spawnTimer = Random.Range(_minSpawnTime, _maxSpawnTime);
        }
    }
}