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

    public virtual void Start() { }

    public virtual void Update() { }

    public void Spawn(float positionX, float positionY)
    {
        Instantiate(_objectToSpawn, new Vector2(positionX, positionY), Quaternion.identity);
    }
}
