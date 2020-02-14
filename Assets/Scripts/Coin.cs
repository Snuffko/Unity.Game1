using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Coin : ObjectsPlayerTrigger
{
    override public void OnCollision(Player player)
    {
        player.PickCoin();
        Destroy(gameObject);
    }
} 