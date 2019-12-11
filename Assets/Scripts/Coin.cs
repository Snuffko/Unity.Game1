using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : SpawnedObject
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Player>().PickCoin();
            Destroy(gameObject);
        }
    }
}
