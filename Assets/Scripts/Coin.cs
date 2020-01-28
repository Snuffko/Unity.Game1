using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : SpawnedObject
{
    override public void OnCollision(Player player)
    {
        player.PickCoin();
        Destroy(gameObject);
    }
} 