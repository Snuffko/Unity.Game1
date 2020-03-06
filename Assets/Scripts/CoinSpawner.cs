using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CoinSpawner : Spawner
{
    [SerializeField] private int _maxCoinInLine;

    protected override float GetHalfHeight()
    {
        return GetComponent<BoxCollider2D>().size.y / 2;
    }

    protected override void Spawn(Vector3 position) 
    { 
        for (int i = 0; i < Random.Range(1, _maxCoinInLine); i++)
        {
            SetPositionX(position.x + i);
            CreateObject();
        }        
    }

    protected override float GetTemplateWidth()
    {
        return _template.GetComponent<CircleCollider2D>().radius * 2;
    }
}