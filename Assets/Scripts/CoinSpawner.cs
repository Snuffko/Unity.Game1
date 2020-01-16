using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class CoinSpawner : Spawner
{
    override public float GetHalfHeight() 
    {
        return GetComponent<BoxCollider2D>().size.y / 2;
    }

    override public void Spawning() 
    { 
        float positionY = Random.Range(transform.position.y - _halfHeight, transform.position.y + _halfHeight);
        for (int i = 0; i < Random.Range(1, 6); i++)
        {
            Spawn(transform.position.x + i, positionY);
        }        
    }
} 