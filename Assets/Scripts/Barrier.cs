using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class Barrier : ObjectsPlayerTrigger
{
    public override void OnCollision(Player player)
    {
        player.Die();
    }
} 