using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : SpawnedObject
{
    override public void OnCollision(Player player)
    {
        player.Die();
    }
} 