using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawner : Spawner
{
    public override float GetHalfHeight()
    {
        return _template.GetComponent<BoxCollider2D>().size.y / 2;
    }

    public override Vector3 GetPosition()
    {
        float positionY = Random.Range(transform.position.y - _halfHeight, transform.position.y);
        return new Vector3(transform.position.x, positionY);
    }

    public override float GetTemplateWidth()
    {
        return _template.GetComponent<BoxCollider2D>().size.x;
    }
}