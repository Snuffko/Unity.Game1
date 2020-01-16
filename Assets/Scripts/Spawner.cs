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

    private void Start() 
    { 
        _spawnTimer = Random.Range(_minSpawnTime, _maxSpawnTime);
        _halfHeight = GetHalfHeight();
    }

    private void Update() 
    {
         _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0) 
        {
            Spawning();
            _spawnTimer = Random.Range(_minSpawnTime, _maxSpawnTime);
        }
    }

    public virtual float GetHalfHeight() 
    {
        return 0;
    }

    public virtual void Spawning() {} 

    protected void Spawn(float positionX, float positionY) 
    {
        Instantiate(_objectToSpawn, new Vector2(positionX, positionY), Quaternion.identity);
    }

}