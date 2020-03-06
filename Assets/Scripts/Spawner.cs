using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Spawner : MonoBehaviour
{
    [SerializeField] protected GameObject _template;
    [SerializeField] protected float _minSpawnTime;
    [SerializeField] protected float _maxSpawnTime;
    [SerializeField] private LayerMask _layerToCheck;

    private float _spawnTimer;
    private float _halfHeight;
    private float _radiusToCheck;
    private Vector3 _currentPosition;

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

    private Vector3 GetPosition()
    {
        float positionY = Random.Range(transform.position.y - _halfHeight, transform.position.y + GetPositionOffset());
        return new Vector3(transform.position.x, positionY);
    }

    private bool CanSpawn()
    {
        return !Physics2D.OverlapCircle(_currentPosition, _radiusToCheck * 1.5f, _layerToCheck);
    }

    public void SetPositionX(float x)
    {
        _currentPosition.x = x;
    }

    protected void CreateObject()
    {
        Instantiate(_template, _currentPosition, Quaternion.identity);
    }

    protected abstract float GetHalfHeight();

    protected abstract float GetTemplateWidth();

    protected abstract void Spawn(Vector3 position);

    protected virtual float GetPositionOffset()
    {
        return _halfHeight;
    }
}