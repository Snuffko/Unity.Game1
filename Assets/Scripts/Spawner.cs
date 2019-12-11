using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] protected GameObject _objectToSpawn;
    [SerializeField] protected float _minSpawnTime;
    [SerializeField] protected float _maxSpawnTime;

    protected float _spawnTimer;
    protected float _halfHeight;
}
