using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] protected GameObject _template;
    [SerializeField] protected float _minSpawnTime;
    [SerializeField] protected float _maxSpawnTime;
    [SerializeField] private LayerMask _layerToCheck;

    protected float _spawnTimer;
    protected float _halfHeight;
    protected float _radiusToCheck;
    protected Vector3 _currentPosition;

    private void Start() 
    { 
        _spawnTimer = Random.Range(_minSpawnTime, _maxSpawnTime);
        _halfHeight = GetHalfHeight();
        _radiusToCheck = GetTemplateWidth();
    }

    private void Update() 
    {
         _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0) 
        {
            _currentPosition = GetPosition();
            if (CanSpawn())
            {
                Spawn(_currentPosition);
            }
            _spawnTimer = Random.Range(_minSpawnTime, _maxSpawnTime);
        }
    }

    protected void CreateObject()
    {
        Instantiate(_template, _currentPosition, Quaternion.identity);
    }

    public virtual float GetHalfHeight()
    {
        return 0;
    }

    public virtual float GetTemplateWidth()
    {
        return 0;
    }


    public virtual void Spawn(Vector3 position) {  
        CreateObject();
    } 

    public virtual Vector3 GetPosition() {
        return new Vector3();
    }

    private bool CanSpawn()
    {
        return !Physics2D.OverlapCircle(_currentPosition, _radiusToCheck * 1.5f, _layerToCheck);
    }
}