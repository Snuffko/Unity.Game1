using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawner : Spawner
{
    override public float GetHalfHeight() 
    {
        return _objectToSpawn.GetComponent<BoxCollider2D>().size.y / 2;
    }

    override public void Spawning() 
    {
        float positionY = Random.Range(transform.position.y - _halfHeight, transform.position.y);
        Spawn(transform.position.x, positionY);
    }
}