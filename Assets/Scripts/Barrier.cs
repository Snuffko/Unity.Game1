using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : PlayerTrigger
{
    public override void OnCollision(Player player)
    {
        player.Die();
    }
} 