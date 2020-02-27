using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CoinSpawner : Spawner
{
    [SerializeField] private int _maxCoinInLine;

    public override float GetHalfHeight()
    {
        return GetComponent<BoxCollider2D>().size.y / 2;
    }

    public override void Spawn(Vector3 position) 
    { 
        for (int i = 0; i < Random.Range(1, _maxCoinInLine); i++)
        {
            _currentPosition.x = position.x + i;
            CreateObject();
        }        
    }

    public override Vector3 GetPosition() 
    {
        float positionY = Random.Range(transform.position.y - _halfHeight, transform.position.y + _halfHeight);
        return new Vector3(transform.position.x, positionY);
    }


    public override float GetTemplateWidth()
    {
        return _template.GetComponent<CircleCollider2D>().radius * 2;
    }
}