using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteArea : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin") || collision.gameObject.CompareTag("Barrier"))
        {
            Destroy(collision.gameObject);
        }
    }
} 