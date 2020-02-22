using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : PlayerTrigger
{
    override public void OnCollision(Player player)
    {
        player.PickCoin();
        Destroy(gameObject);
    }
} 