using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrierSpawner : Spawner
{
    protected override float GetHalfHeight()
    {
       return _template.GetComponent<BoxCollider2D>().size.y / 2;
    }

    protected override float GetTemplateWidth()
    {
        return _template.GetComponent<BoxCollider2D>().size.x;
    }

    protected override void Spawn(Vector3 position)
    {
        CreateObject();
    }

    protected override float GetPositionOffset()
    {
        return 0;
    }
}